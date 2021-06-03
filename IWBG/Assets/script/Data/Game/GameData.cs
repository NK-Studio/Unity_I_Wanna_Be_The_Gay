public enum DIFFICULTY
{
    NONE,
    MEDIUM,
    HARD,
    VERYHARD,
    EXCRUCIATING
}

public struct GameData
{
    public float player_X;
    public float player_Y;
    public float player_Flip;
    public DIFFICULTY Difficulty;
    public int DeathCount;

    public GameData(float player_X, float player_Y, float player_Flip, DIFFICULTY difficulty, int deathCount)
    {
        this.player_X = player_X;
        this.player_Y = player_Y;
        this.player_Flip = player_Flip;
        Difficulty = difficulty;
        DeathCount = deathCount;
    }
}
