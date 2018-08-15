namespace SpacechemPatch.Patches
{
    [Decoy("#=qml1pJoAiVhP0DrNfz58QwayWRFNmD1asJqQ$gRcjmdo=")]
    static class UserManager
    {
        [Decoy("#=qI46CsnuLWP0YZLuDbu3IaZr8vtfYGZ0I_x7krqbKhM8=")]
        public static User GetCurrentUser()
        {
            return null;
        }
    }
}
