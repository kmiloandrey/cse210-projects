using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        //  5 different prompts
        _prompts.Add("What is something new I learned or realized today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was a small detail or moment today that made me smile?");
        _prompts.Add("How did I take care of my physical or mental well-being today?");
        _prompts.Add("What was the most interesting thing I saw today?");
    }

    // random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}