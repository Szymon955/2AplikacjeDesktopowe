using System.Collections.Generic;
using Avalonia.Controls;

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

        new SurveyQuestion("Czy lubisz programowac?");

        new SurveyQuestion("Czy lubisz plywac?");

        new SurveyQuestion("Czy lubisz biegac?");
    }
    
}