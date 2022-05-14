﻿using Calculator2.Model.CalculatingDateModel;
using Calculator2.Views.DatePages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator2.ViewModel
{
    public class CalculatingDateViewModel : BaseViewModel
    {
        private Page _dateModePages;

        public Page DateModePages
        {
            get { return _dateModePages; }
            set
            {
                _dateModePages = value;
                RaisePropertyChanged(nameof(DateModePages));
            }
        }


        private List<String> _dateModeItems = new() { "Вычисление интервала между двумя датами", "Добавление или вычитание дней до указанной даты" };

        public List<String> DateModeItems
        {
            get { return _dateModeItems; }
            set
            {
                _dateModeItems = value;
                RaisePropertyChanged(nameof(DateModeItems));
            }
        }

        private string _dateMode;

        public string DateMode
        {
            get { return _dateMode; }
            set
            {
                _dateMode = value;
                RaisePropertyChanged(nameof(DateMode));

                DateModePages = DateMode == DateModeItems.FirstOrDefault() ? _date1 : _date2;
            }
        }

        BaseCalculatingDateModel _dateModel;

        Date1 _date1;

        Date2 _date2;

        public CalculatingDateViewModel()
        {
            this._dateModel = new();

            this._date1 = new();

            this._date2 = new();

            DateMode = DateModeItems.FirstOrDefault();

            DateModePages = _date1;
        }
    }
}
