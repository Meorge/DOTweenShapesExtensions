using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes;
using DG.Tweening;

public static class DOTweenShapesExtensionsDisc
{
    public static Tween DOColor(this Disc disc, Color to, float duration) {
        return DOTween.To(() => disc.Color, x => disc.Color = x, to, duration);
    }

    public static Tween DOAlpha(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.Color.a, x => { Color c = disc.Color; c.a = x; disc.Color = c; }, to, duration);
    }

    public static Tween DOColorInner(this Disc disc, Color to, float duration) {
        return DOTween.To(() => disc.ColorInner, x => disc.ColorInner = x, to, duration);
    }

    public static Tween DOAlphaInner(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.ColorInner.a, x => { Color c = disc.ColorInner; c.a = x; disc.ColorInner = c; }, to, duration);
    }

    public static Tween DOColorOuter(this Disc disc, Color to, float duration) {
        return DOTween.To(() => disc.ColorOuter, x => disc.ColorOuter = x, to, duration);
    }

    public static Tween DOAlphaOuter(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.ColorOuter.a, x => { Color c = disc.ColorOuter; c.a = x; disc.ColorOuter = c; }, to, duration);
    }

    public static Tween DOColorOuterStart(this Disc disc, Color to, float duration) {
        return DOTween.To(() => disc.ColorOuterStart, x => disc.ColorOuterStart = x, to, duration);
    }

    public static Tween DOAlphaOuterStart(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.ColorOuterStart.a, x => { Color c = disc.ColorOuterStart; c.a = x; disc.ColorOuterStart = c; }, to, duration);
    }

    public static Tween DOColorInnerEnd(this Disc disc, Color to, float duration) {
        return DOTween.To(() => disc.ColorInnerEnd, x => disc.ColorInnerEnd = x, to, duration);
    }

    public static Tween DOAlphaInnerEnd(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.ColorInnerEnd.a, x => { Color c = disc.ColorInnerEnd; c.a = x; disc.ColorInnerEnd = c; }, to, duration);
    }

    public static Tween DOColorOuterEnd(this Disc disc, Color to, float duration) {
        return DOTween.To(() => disc.ColorOuterEnd, x => disc.ColorOuterEnd = x, to, duration);
    }

    public static Tween DOAlphaOuterEnd(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.ColorOuterEnd.a, x => { Color c = disc.ColorOuterEnd; c.a = x; disc.ColorOuterEnd = c; }, to, duration);
    }

    public static Tween DORadius(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.Radius, x => disc.Radius = x, to, duration);
    }

    public static Tween DOThickness(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.Thickness, x => disc.Thickness = x, to, duration);
    }

    public static Tween DOAngleStart(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.AngRadiansStart, x => disc.AngRadiansStart = x, to, duration);
    }

    public static Tween DOAngleEnd(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.AngRadiansEnd, x => disc.AngRadiansEnd = x, to, duration);
    }

    public static Tween DODashSize(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.DashSize, x => disc.DashSize = x, to, duration);
    }

    public static Tween DODashSpacing(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.DashSpacing, x => disc.DashSpacing = x, to, duration);
    }

    public static Tween DODashOffset(this Disc disc, float to, float duration) {
        return DOTween.To(() => disc.DashOffset, x => disc.DashOffset = x, to, duration);
    }
}
