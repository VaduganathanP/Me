using Me.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WPF.Common;

namespace Me.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Reply _CurrentReply;

        string _question;
        public string Question
        {
            get { return _question; }
            set
            {
                if (_question != value)
                {
                    _question = value;
                    RaisePropertyChanged();
                    Answer = String.Empty;
                    DisplayValue = string.Empty;
                    NextButtonVisibility = Visibility.Hidden;
                }
            }
        }

        string _answer;
        public string Answer
        {
            get { return _answer; }
            set
            {
                if (_answer != value)
                {
                    _answer = value;
                    RaisePropertyChanged();
                }
            }
        }

        string _displayValue;
        public string DisplayValue
        {
            get { return _displayValue; }
            set
            {
                if (_displayValue != value)
                {
                    _displayValue = value;
                    RaisePropertyChanged();
                }
            }
        }

        bool _questionFocus;
        public bool QuestionFocus
        {
            get { return _questionFocus; }
            set
            {
                if (_questionFocus != value)
                {
                    _questionFocus = value;
                    RaisePropertyChanged();
                }
            }
        }

        bool _displayAreaFocus;
        public bool DisplayAreaFocus
        {
            get { return _displayAreaFocus; }
            set
            {
                if (_displayAreaFocus != value)
                {
                    _displayAreaFocus = value;
                    RaisePropertyChanged();
                }
            }
        }

        Visibility _nextButtonVisibility = Visibility.Hidden;
        public Visibility NextButtonVisibility
        {
            get { return _nextButtonVisibility; }
            set
            {
                if (_nextButtonVisibility != value)
                {
                    _nextButtonVisibility = value;
                    RaisePropertyChanged();
                }
            }
        }

        string _nextButtonContent;
        public string NextButtonContent
        {
            get { return _nextButtonContent; }
            set
            {
                if (NextButtonContent != value)
                {
                    _nextButtonContent = value;
                    RaisePropertyChanged();
                }
            }
        }
        public ICommand NextAnswerCommand
        {
            get
            {
                return new RelayCommand(NextAnswerCommandMethod);
            }
        }

        private void NextAnswerCommandMethod()
        {
            _CurrentReply = Me.Core.Answer.GetAnswer(_CurrentReply);
            SetAnswer();
        }

        public ICommand SubmitCommand
        {
            get
            {
                return new RelayCommand(SubmitCommandMethod);
            }
        }

        private void SubmitCommandMethod()
        {
            string answer, displayValue;
            answer = Answer;
            displayValue = DisplayValue;

            if (string.IsNullOrEmpty(Question) && (!string.IsNullOrEmpty(Answer) || !string.IsNullOrEmpty(DisplayValue)) && !string.IsNullOrEmpty(_CurrentReply.Question))
            {
                Question = _CurrentReply.Question;
            }
            _CurrentReply = Me.Core.Question.Process(new Core.Request() { IsConversation = false, Question = Question, Answer = answer, DisplayValue = displayValue });
            SetAnswer();
        }

        void SetAnswer()
        {
            if (_CurrentReply != null && _CurrentReply.IsAnswer)
            {
                Question = string.Empty;
                Answer = string.Empty;
                DisplayValue = _CurrentReply.DisplayValue;
                DisplayAreaFocus = true;
                NextButtonContent = ">> " + _CurrentReply.CurrentAnswerIndex + " of " + _CurrentReply.Answers.Count;
                NextButtonVisibility = Visibility.Visible;
            }
            else
            {
                Question = string.Empty;
                Answer = string.Empty;
                DisplayValue = string.Empty;
                QuestionFocus = true;
                NextButtonVisibility = Visibility.Hidden;
            }
        }
    }
}
