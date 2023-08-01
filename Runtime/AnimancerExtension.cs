using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Animancer;

namespace HRYooba.Library
{
    public static class AnimancerExtension
    {
        public static AnimancerState PlayOnce(this AnimancerComponent animancer, AnimationClip clip, bool pausePlayable = false)
        {
            var state = animancer.Play(clip);

            state.Events.OnEnd = () => state.IsPlaying = false;
            if (pausePlayable)
            {
                animancer.Playable.UnpauseGraph();
                state.Events.OnEnd += () => animancer.Playable.PauseGraph();
            }

            return state;
        }

        public static AnimancerState PlayOnce(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, bool pausePlayable = false)
        {
            var state = animancer.Play(clip, fadeDuration);

            state.Events.OnEnd = () => state.IsPlaying = false;
            if (pausePlayable)
            {
                animancer.Playable.UnpauseGraph();
                state.Events.OnEnd += () => animancer.Playable.PauseGraph();
            }

            return state;
        }

        public static AnimancerState PlayOnce(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode, bool pausePlayable = false)
        {
            var state = animancer.Play(clip, fadeDuration, fadeMode);

            state.Events.OnEnd = () => state.IsPlaying = false;
            if (pausePlayable)
            {
                animancer.Playable.UnpauseGraph();
                state.Events.OnEnd += () => animancer.Playable.PauseGraph();
            }

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

        public static async UniTask<AnimancerState> PlayOnceAsync(this AnimancerComponent animancer, AnimationClip clip, CancellationToken cancellationToken, bool pausePlayable = false)
        {
            var state = animancer.PlayOnce(clip, pausePlayable);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayOnceAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, CancellationToken cancellationToken, bool pausePlayable = false)
        {
            var state = animancer.PlayOnce(clip, fadeDuration, pausePlayable);
            await state.WithCancellation(cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayOnceAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode, CancellationToken cancellationToken, bool pausePlayable = false)
        {
            var state = animancer.PlayOnce(clip, fadeDuration, fadeMode, pausePlayable);
            await state.WithCancellation(cancellationToken);
            return state;
        }
    }
}