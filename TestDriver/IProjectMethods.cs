﻿namespace TestDriver
{
    public interface IProjectMethods
    {
        string ProjectName { get; }

        void DoAction(string action, string parent = null, string child = null, string data = null, string modifier = null);

    }
}
