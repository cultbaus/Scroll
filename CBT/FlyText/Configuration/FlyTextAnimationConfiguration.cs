namespace CBT.FlyText.Configuration;

using CBT.FlyText.Animations;

/// <summary>
/// FlyTextAnimation configuration.
/// </summary>
internal class FlyTextAnimationConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlyTextAnimationConfiguration"/> class.
    /// </summary>
    /// <param name="kind">Kind of animation.</param>
    /// <param name="duration">Duration of the animation.</param>
    /// <param name="speed">Speed which the animation should reach the end state.</param>
    internal FlyTextAnimationConfiguration(FlyTextAnimationKind kind, float duration, float speed)
    {
        this.Kind = kind;
        this.Duration = duration;
        this.Speed = speed;
    }

    /// <summary>
    /// Gets or sets the animation kind.
    /// </summary>
    internal FlyTextAnimationKind Kind { get; set; }

    /// <summary>
    /// Gets or sets the duration.
    /// </summary>
    internal float Duration { get; set; }

    /// <summary>
    /// Gets or sets the speed.
    /// </summary>
    internal float Speed { get; set; }
}