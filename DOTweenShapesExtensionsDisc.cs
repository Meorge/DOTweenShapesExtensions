using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes;
using DG.Tweening;

public static class DOTweenShapesExtensionsDisc
{
    // a comment
    public static Tween DORadius(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.Radius, radius => disc.Radius = radius, to, duration);
    }
}
