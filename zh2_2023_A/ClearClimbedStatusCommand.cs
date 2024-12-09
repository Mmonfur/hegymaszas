using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace zh2_2023_A
{
    public class ClearClimbedStatusCommand : ICommand
    {
        private readonly ObservableCollection<Mountain> _mountains;

        // Az ICommand interfész CanExecuteChanged eseménye
        public event EventHandler? CanExecuteChanged;

        public ClearClimbedStatusCommand(ObservableCollection<Mountain> mountains)
        {
            _mountains = mountains;
        }

        // Meghatározza, hogy a parancs végrehajtható-e (mindig true jelen esetben)
        public bool CanExecute(object? parameter) => true;

        // Parancs végrehajtása: Törli az összes "megmásztam" jelölést
        public void Execute(object? parameter)
        {
            foreach (var mountain in _mountains)
            {
                mountain.HasClimbed = false; // A zöld kijelölést visszaállítjuk feketére
            }
        }
    }
}

