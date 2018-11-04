using System;
using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qbOdrLIRO_tcg0__kGmg_wQ==")]
    internal class AbstractRenderable
    {
        [Decoy("#=qiStj8U4JZ2wlQtREO8VN0A==")]
        public static readonly AbstractRenderable EMPTY;

        [Decoy("#=qedibsGLShIzRSXZ1OScamA==")]
        public static AbstractRenderable MakeTexturedRectangle(TextureElement textureElement) => null;

        [Decoy("#=qOxnFDbKrOuIgr26kLrf9CQ==")]
        internal static AbstractRenderable MakeLabel(Font font, string str) => null;

        [Decoy("#=q9SjrznTM3JD8Ik500veQwg==")]
        public static AbstractRenderable MakeColoredLabel(Font font, string text, Color color) => null;

        [Decoy("#=qEURq16$r$UCXmQ_$T_oUdw==")]
        public static AbstractRenderable MakeBlankRenderable(BoundingBox boundingBox) => null;

        [Decoy("#=qjKpxqj4E$KFAeuZbPsUN8w==")]
        public AbstractRenderable NullSafeWithAddedRenderable(AbstractRenderable renderable) => null;

        [Decoy("#=qcWvYmlzeSCXd3dvNUFFQnQ==")]
        public AbstractRenderable WithColor(Color color) => null;

        [Decoy("#=qD_M7_V8NtYHBWDm02TIxbg==")]
        public AbstractRenderable WithTranslation(Vector2i translationVector) => null;

        [Decoy("#=q8iSNeH0$gCiWaApfKC8Xqg==")]
        public AbstractRenderable WithTranslation(int x, int y) => null;

        [Decoy("#=qB3wR2Cci50lPgEP$Gktzgg==")]
        public AbstractRenderable WithAddedCenteredRenderable(AbstractRenderable renderable) => null;

        [Decoy("#=qM_FOMN5MqYm2lHt5tEfmHA==")]
        public AbstractRenderable WithAddedRenderableBelow(AbstractRenderable renderable, HorizontalAlignment alignment, int padding) => null;

        [Decoy("#=q$QK6aPuw$c85xKsFAVElsA==")]
        public AbstractRenderable WithAddedRenderableAbove(AbstractRenderable renderable, HorizontalAlignment alignment, int padding) => null;

        [Decoy("#=qTLifiY4GmGLCmEWwNPNytw==")]
        public static AbstractRenderable LayoutHorizontally(VerticalAlignment alignment, int padding, IEnumerable<AbstractRenderable> renderables) => null;

        [Decoy("#=qrtfgsXRYwNeh6fMxHSBgAw==")]
        public static AbstractRenderable LayoutVertically(HorizontalAlignment alignment, int padding, IEnumerable<AbstractRenderable> renderables) => null;
    }
}