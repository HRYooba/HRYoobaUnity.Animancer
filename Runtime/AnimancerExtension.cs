using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Animancer;

namespace HRYooba.Library
{
    public static class AnimancerExtension
    {
        public static AnimancerState PlayOnce(this AnimancerComponent animancer, AnimationClip clip)
        {
            var state = animancer.Play(clip);
            state.Events.OnEnd = () => state.IsPlaying = false;
            return state;
        }

        public static AnimancerState PlayOnce(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration)
        {
            var state = animancer.Play(clip, fadeDuration);
            state.Events.OnEnd = () => state.IsPlaying = false;
            return state;
        }

        public static AnimancerState PlayOnce(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode)
        {
            var state = animancer.Play(clip, fadeDuration, fadeMode);
            state.Events.OnEnd = () => state.IsPlaying = false;
            return state;
        }

        public static async UniTask<AnimancerState> PlayAsync(this AnimancerComponent animancer, AnimationClip clip, CancellationToken cancellationToken)
        {
            var state = animancer.Play(clip);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, CancellationToken cancellationToken)
        {
            var state = animancer.Play(clip, fadeDuration);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode, CancellationToken cancellationToken)
        {
            var state = animancer.Play(clip, fadeDuration, fadeMode);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayOnceAsync(this AnimancerComponent animancer, AnimationClip clip, CancellationToken cancellationToken)
        {
            var state = animancer.PlayOnce(clip);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayOnceAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, CancellationToken cancellationToken)
        {
            var state = animancer.PlayOnce(clip, fadeDuration);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayOnceAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode, CancellationToken cancellationToken)
        {
            var state = animancer.PlayOnce(clip, fadeDuration, fadeMode);
            await state.WithCancellation(cancellationToken);
            return state;
        }
    }
}