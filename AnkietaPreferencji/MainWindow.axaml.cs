using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Tmds.DBus.Protocol;

namespace AnkietaPreferencji;

public partial class MainWindow : Window
{
    private List<SurveyQuestion> Questions;

    public MainWindow()
    {
        InitializeComponent();
        InitializeQuestions();
    }

    private void InitializeQuestions()
    {
        
        Questions = new List<SurveyQuestion>();

        
        Questions.Add(new SurveyQuestion("Czy lubisz programowac?"));
        Questions.Add(new SurveyQuestion("Czy lubisz plywac?"));
        Questions.Add(new SurveyQuestion("Czy lubisz biegac?"));
    }
    
    private void OnFinishClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Dziekujemy");
    
    }

    private void OnSubmitClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Dziekujemy");
    }
}



public class SurveyQuestion
{
    public string QuestionText { get; set; }

    public SurveyQuestion(string questionText)
    {
        QuestionText = questionText;
    }
}


