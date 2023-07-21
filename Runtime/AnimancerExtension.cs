using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Animancer;

namespace HRYooba.Library
{
    public static class AnimancerExtension
    {
        public static async UniTask<AnimancerState> PlayAsync(this AnimancerComponent animancer, AnimationClip clip, CancellationToken cancellationToken)
        {
            var state = animancer.Play(clip);
            await UniTask.WaitWhile(() => state.IsPlaying, cancellationToken: cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, CancellationToken cancellationToken)
        {
            var state = animancer.Play(clip, fadeDuration);
            await UniTask.WaitWhile(() => state.IsPlaying, cancellationToken: cancellationToken);
            return state;
        }

        public static async UniTask<AnimancerState> PlayAsync(this AnimancerComponent animancer, AnimationClip clip, float fadeDuration, FadeMode fadeMode, CancellationToken cancellationToken)
        {
            var state = animancer.Play(clip, fadeDuration, fadeMode);
            await UniTask.WaitWhile(() => state.IsPlaying, cancellationToken: cancellationToken);
            return state;
        }
    }
}