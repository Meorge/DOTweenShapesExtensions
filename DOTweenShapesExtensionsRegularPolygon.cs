using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes;
using DG.Tweening;

public static class DOTweenShapesExtensionsRegularPolygon
{
    public static Tween DOColor(this RegularPolygon polygon, Color to, float duration) {
        return DOTween.To(() => polygon.Color, x => polygon.Color = x, to, duration);
    }
}