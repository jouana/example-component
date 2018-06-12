using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ExampleGridItemsHost.HostGrid
{
    /// <summary>
    /// Suivez les étapes 1a ou 1b puis 2 pour utiliser ce contrôle personnalisé dans un fichier XAML.
    ///
    /// Étape 1a) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans le projet actif.
    /// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
    /// être utilisé :
    ///
    ///     xmlns:MyNamespace="clr-namespace:ExampleGridItemsHost.HostGrid"
    ///
    ///
    /// Étape 1b) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans un autre projet.
    /// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
    /// être utilisé :
    ///
    ///     xmlns:MyNamespace="clr-namespace:ExampleGridItemsHost.HostGrid;assembly=ExampleGridItemsHost.HostGrid"
    ///
    /// Vous devrez également ajouter une référence du projet contenant le fichier XAML
    /// à ce projet et regénérer pour éviter des erreurs de compilation :
    ///
    ///     Cliquez avec le bouton droit sur le projet cible dans l'Explorateur de solutions, puis sur
    ///     "Ajouter une référence"->"Projets"->[Recherchez et sélectionnez ce projet]
    ///
    ///
    /// Étape 2)
    /// Utilisez à présent votre contrôle dans le fichier XAML.
    ///
    ///     <MyNamespace:MyGrid/>
    ///
    /// </summary>
    public class MyGrid : Control
    {
        static MyGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyGrid), new FrameworkPropertyMetadata(typeof(MyGrid)));
        }

        public MyGrid()
        {
            this.ItemsSource = new List<object>();
        }

        public override void EndInit()
        {
            base.EndInit();
        }

        public List<object> ItemsSource
        {
            get { return (List<object>)GetValue(ItemsSourceProperty); }
            set
            {
                SetValue(ItemsSourceProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(List<object>), typeof(MyGrid), new PropertyMetadata(null, itemssourcepropchanged));

        private static void itemssourcepropchanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var a = e;
        }

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemDataTemplate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register(nameof(ItemTemplate), typeof(DataTemplate), typeof(MyGrid), new PropertyMetadata(null, itemtempaltepropchanged));

        private static void itemtempaltepropchanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var a = e;
        }
    }
}
