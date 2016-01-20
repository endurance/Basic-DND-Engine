namespace DnDEngine.Characters.Races
{
    public enum AgeStatus
    {
        MiddleAge,
        Old,
        Venerable,
        None
    }
    public interface IRace
    {
        // TODO: Filter down what all races have in common
        AgeStatus GetAgeStatus(int age);
    }
}
