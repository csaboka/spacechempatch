using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qtl2wJnXgM0Mq3un0pcVWel4o1GcuH8cP$M_0vYWJiS0=")]
    class Reactor
    {
        [Decoy("#=quKOf4M5LMedp7EckR5fqMw==")]
        public MoleculeList moleculeList;
        [Decoy("#=qh3XgfGHlRPf7$f$mMuy6AA==")]
        public Dictionary<ReactorLayer, Waldo> waldos;
        [Decoy("#=q9jpD6KA9Jz2vQ6PWazoFrQ==")]
        public ReactorScreen reactorScreen;

        [Decoy(".ctor")]
        public Reactor(ReactorScreen reactorScreen, Vector2i position, Vector2i dimensions, ReactorLayout genum2_1, bool bool_2 = false)
        {

        }

        [Decoy("#=qZ3mqnGc9DDHuYhhM_UXxgQ==")]
        public IEnumerable<ReactorMember> GetMembers()
        {
            return null;
        }

        [Decoy("#=qxU2FtX7PCPSqVgohhP$fIA==")]
        public void AddMember(Vector2i coords, ReactorLayer layer, ReactorMember member)
        {

        }

        [Decoy("#=qdGknNhsVKU36v57KpaHHLw==")]
        public CoordsLayer? GetCoordsOfMemberOrEmpty(ReactorMember member)
        {
            return null;
        }

        [Replaced("#=qWRMFkk4TfVLPMRWPoTWvsA==", Patch.StricterCollisionChecks)]
        public void OnCyclePhase1()
        {
            foreach (Molecule molecule in moleculeList)
                molecule.PrepareForNewCycle();
            // The next line is our only change. By forcing a collision check after the
            // molecule positions are finalized but before instructions are executed,
            // we can catch rotate-based smash attempts.
            reactorScreen.simulationEngine.DoCollisionChecks();
            foreach (Waldo waldo in waldos.Values)
                waldo.Move();
        }


    }
}
