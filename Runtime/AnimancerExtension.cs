using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Animancer;

namespace HRYooba.Library
{
    public static class AnimancerExtension
    {
        public static AnimancerState Play(this AnimancerComponent animancer, AnimationClip clip, Action onEnd = null)
        {
            var state = animancer.Play(clip);
            state.Events.OnEnd += () =>
            {
                onEnd?.Invoke();
                state.Events.Clear();
            };
            return state;
        }

        public static AnimancerState Play(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, Action onEnd = null)
        {
            var state = animancer.Play(clip, fadeDuration);
            state.Events.OnEnd += () =>
            {
                onEnd?.Invoke();
                state.Events.Clear();
            };
            return state;
        }

        public static AnimancerState Play(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode, Action onEnd = null)
        {
            var state = animancer.Play(clip, fadeDuration, fadeMode);
            state.Events.OnEnd += () =>
            {
                onEnd?.Invoke();
                state.Events.Clear();
            };
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
    }
}