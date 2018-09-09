using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qdKGLnt2KfTK9zD4G7oVABoHPmqWKuNs4WSYAqh1HVZ3susdV5V8wUWO$qRFxovFL")]
    internal sealed class QuantumTunnelFeature : AbstractFeature
    {
        [Decoy("#=qa0QxpVhmfLS1WO91plaUCRamQlwOY23o$ibhDoTuNdA=")]
        private static readonly TextureElement blueLaser;
        [Decoy("#=q$oFzzpLeoVaQf2rMVZ9VhjxEwUGRWlvsOkhduy1HgKc=")]
        private static readonly TextureElement redLaser;
        [Decoy("#=qCSmVWrSkoLd8f$CUQXaBUmLSrRPIc0dAryo6JVWtZ6E=")]
        private static readonly TextureElement blueSensorCircle;
        [Decoy("#=qFu4mEDQvnqlq4CBjtaC2Fg==")]
        private static readonly TextureElement redSensorCircle;
        [Decoy("#=qkKoib5RaKQToazAaWPQntX2MPC_keofu24lxbOAbw_k=")]
        private static readonly float ANIMATION_LENGTH;

        [Decoy("#=q1w52cJ$$hD1OQ$W3Z5eerg==")]
        private Optional<float> sensorCircleState;
        [Decoy("#=qOJ3iyYwoOzM3NMn9cDaUAw==")]
        private Optional<float> laserState;
        [Decoy("#=qmEsHp4ypq94Kde6x5jy$KQ==")]
        private bool isActivatedForRed;
        [Injected]
        private bool isSensorActivatedForRed;

        [Decoy(".ctor")]
        public QuantumTunnelFeature(Reactor reactor) :
            base(null, null, false, null, default(Vector2i))    // This is not the real super call, just here to make the compiler happy.
        {

        }

        [Decoy("#=qI06nyL1WVgy2Ys$lzQ9oSBmOl2PDEMrXVuLi5FeDVf4=")]
        private static Optional<MoleculeDefinition> TearOutAtomOnTunnel(Reactor reactor, Vector2i tunnelPosition)
        {
            return new Optional<MoleculeDefinition>();
        }

        [Injected]
        private static void CollectTunnels(Reactor reactor, out List<QuantumTunnelFeature> allTunnels, out List<Vector2i> tunnelPositions)
        {
            allTunnels = new List<QuantumTunnelFeature>();
            tunnelPositions = new List<Vector2i>();
            foreach (ReactorMember member in reactor.GetMembers())
            {
                if (member is QuantumTunnelFeature)
                {
                    allTunnels.Add(member as QuantumTunnelFeature);
                    tunnelPositions.Add(reactor.GetCoordsOfMemberOrEmpty(member).Value.coords);
                }
            }
        }

        [Replaced("#=qeNhC8QdFCxzKODPkPKLu8Q==", Patch.MoreFeaturesInResNetResearch)]
        public static void DoSwap(Reactor reactor, bool forRed)
        {
            List<QuantumTunnelFeature> allTunnels;
            List<Vector2i> tunnelPositions;
            CollectTunnels(reactor, out allTunnels, out tunnelPositions);
            int tunnelCount = allTunnels.Count;
            if (tunnelCount == 0)
            {
                return;
            }
            List<Optional<MoleculeDefinition>> removedAtoms = new List<Optional<MoleculeDefinition>>();
            for (int i = 0; i < tunnelCount; i++)
            {
                removedAtoms.Add(TearOutAtomOnTunnel(reactor, tunnelPositions[i]));
            }
            // repeat the first element at the end to simplify roll-around logic
            allTunnels.Add(allTunnels[0]);
            tunnelPositions.Add(tunnelPositions[0]);
            for (int i = 0; i < tunnelCount; i++)
            {
                if (removedAtoms[i].isPresent)
                {
                    MoleculeDefinition atomToMove = removedAtoms[i].GetValue();
                    atomToMove.Translate(tunnelPositions[i + 1]);
                    reactor.moleculeList.Add(new Molecule(atomToMove, reactor));
                    allTunnels[i].laserState = 0.0f;
                    allTunnels[i].Activate(forRed);
                    // we hijack the already existing boolean field for storing whether
                    // the laser is activated for red, and use a new injected field
                    // for storing the same thing for the sensor
                    allTunnels[i].isActivatedForRed = forRed;
                    allTunnels[i + 1].sensorCircleState = 0.0f;
                    allTunnels[i + 1].Activate(forRed);
                    allTunnels[i + 1].isSensorActivatedForRed = forRed;
                }
            }
            foreach (Waldo waldo in reactor.waldos.Values)
            {
                if (waldo.molecule != null)
                {
                    waldo.Drop();
                    waldo.Grab();
                }
            }
        }

        [Replaced("#=qWQJ$dMDcjxjokRp8n71Fzg==", Patch.MoreFeaturesInResNetResearch)]
        public override void Render(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {
            base.Render(spriteBatch, position, layer, GetFeatureColor() * color, zOrder, imageSize, forDragAndDrop);
            List<QuantumTunnelFeature> allTunnels;
            List<Vector2i> tunnelPositions;
            CollectTunnels(ownerReactor, out allTunnels, out tunnelPositions);
            int tunnelIndex = allTunnels.IndexOf(this);
            Vector2i labelPosition = new Vector2i(position.x + image.GetDimensions().x - 7, position.y + 7);
            spriteBatch.AddTextCentered(FontManager.normal, (tunnelIndex + 1).ToString(), labelPosition, GetFeatureColor() * color, zOrder);

            if (!laserState.isPresent && !sensorCircleState.isPresent)
                return;

            if (sensorCircleState.isPresent)
            {
                TextureElement sensorCircle = isSensorActivatedForRed ? redSensorCircle : blueSensorCircle;
                float fineCircleState = sensorCircleState.GetValue() + SimulationGlobals.partialCycle / ANIMATION_LENGTH;
                Color circleColor = Color.WHITE.WithAlpha(0.75f - fineCircleState);
                Vector2i circleSize = (Vector2i)(sensorCircle.GetDimensions() * (float)(1.0 + 1.0 * (double)fineCircleState));
                spriteBatch.AddSprite(sensorCircle, new BoundingBox(boundingBox.GetCenter() + new Vector2i(-1, 0), circleSize), new BoundingBox?(), circleColor, (AngleInRadians)0.0f, circleSize / 2, FlipOptions.None, zOrder - 0.02f);
            }

            allTunnels.Add(allTunnels[0]);
            tunnelPositions.Add(tunnelPositions[0]);

            if (laserState.isPresent)
            {
                TextureElement laserBeam = isActivatedForRed ? redLaser : blueLaser;
                float fineLaserState = laserState.GetValue() + SimulationGlobals.partialCycle / ANIMATION_LENGTH;
                Vector2i startTunnelCenter = allTunnels[tunnelIndex].boundingBox.GetCenter();
                Vector2i endTunnelCenter = allTunnels[tunnelIndex + 1].boundingBox.GetCenter();
                Vector2f beamVector = endTunnelCenter - startTunnelCenter;
                Vector2f beamDirectionVector = beamVector / beamVector.Length();
                Vector2i beamStart = startTunnelCenter + (Vector2i)(beamDirectionVector * 29f);
                Vector2i beamEnd = endTunnelCenter + (Vector2i)(beamDirectionVector * -29f);
                SpriteHelper.AddTextureStretchedBetween(spriteBatch, laserBeam, beamStart, beamEnd, Color.WHITE.WithAlpha((float)((1.0 - (double)fineLaserState) / 2.0)), zOrder - 0.02f);
            }
        }

    }
}
