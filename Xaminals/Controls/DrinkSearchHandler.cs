using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xaminals.Models;

namespace Xaminals.Controls
{
    public class DrinkSearchHandler : SearchHandler
    {
        public IList<Drink> Drinks { get; set; }
        public Type SelectedItemNavigationTarget { get; set; }

        //輸入資料時修改建議
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Drinks
                    .Where(drink => drink.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList<Drink>();
            }
        }

        //選取建議結果
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            // Let the animation complete
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"{GetNavigationTarget()}?name={((Drink)item).Name}");
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        }
    }
}
