using System;
using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q4qD7FM61ItTja0EPTlrb63r6ga_yHM4Ir5SdhMxQEOkU4BIqEwKdXzYSxQO26vnW")]
    internal abstract class AbstractReactorType : AbstractDraggable
    {
        [Decoy("#=qxkv8f2GEsnz86nAScntseg==")]
        public ReactorScreen reactorScreen;

        [Decoy("#=q5QSH1C1ULvgadEsJqtDRdN$V$U00I73CseH3Wqb5PmM=")]
        public HashSet<Type> availableInstructions;

        [Decoy("#=qp6XZsjjLbtsnyvspmRSj$4p6cJ_mmp16bCXRAN4f1TQ=")]
        protected Dictionary<Type, int> availableFeatures;

        [Decoy("#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E=")]
        public abstract void SetCapabilities();

        [Decoy("#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY=")]
        public abstract void InitializeReactor();

        [Decoy("#=qIQeOaIN3irVlptmX_0cEoRDhCcBCv7z5dvfBvJD1A60=")]
        protected bool HasExistingReactor()
        {
            return false;
        }

        [Decoy("#=qsBI9keCp40iwRAL4yMqGFg==")]
        protected void AddStartInstructions()
        {

        }
    }
}