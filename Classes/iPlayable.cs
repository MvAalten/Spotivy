public interface IPlayable
{
    void Play();

    void Pause();

    void Next();

    void Stop();

    int Length { get; }
}
