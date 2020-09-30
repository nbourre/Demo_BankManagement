using BankManagement.Data;
using BankManagement.Models;
using BankManagement.Models.Commands;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace BankManagement.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;
        private ObservableCollection<BankAccount> bankAccounts;
        private BankAccount selectedBankAccount;
        private double transactionAmount;

        public DelegateCommand<object> AddNewCustomerCommand { get; set; }
        public DelegateCommand<string> DebitCommand { get; set; }
        public DelegateCommand<string> CreditCommand { get; set; }

        /// <summary>
        /// Montant de la transaction
        /// </summary>
        public double TransactionAmount 
        { 
            get => transactionAmount;
            set { 
                transactionAmount = value;
                OnProperyChanged();
            }
        }

        /// <summary>
        /// Liste des clients
        /// </summary>
        public ObservableCollection<Customer> Customers
        {
            get => customers;
            set
            {
                customers = value;
                OnProperyChanged();
            }
        }

        // Client
        public Customer SelectedCustomer
        {
            get => selectedCustomer; 
            set
            {
                selectedCustomer = value;

                OnProperyChanged();
            }
        }

        /// <summary>
        /// Comptes
        /// </summary>
        public ObservableCollection<BankAccount> BankAccounts
        {
            get => bankAccounts;
            set
            {
                bankAccounts = value;
                OnProperyChanged();
            }
        }

        /// <summary>
        /// Compte sélectionné
        /// </summary>
        public BankAccount SelectedBankAccount
        {
            get { return selectedBankAccount; }
            set
            {
                selectedBankAccount = value;
                OnProperyChanged();
            }
        }

        public MainViewModel()
        {
            AddNewCustomerCommand = new DelegateCommand<object>(AddNewCustomer);
            CreditCommand = new DelegateCommand<string>(CreditToAccount, CanAddCredit);
            DebitCommand = new DelegateCommand<string>(DebitFromAccount, CanDebit);

            Customers = new ObservableCollection<Customer>(new CustomerDataService().GetAll());
            BankAccounts = new ObservableCollection<BankAccount>(new BankAccountDataService(Customers).GetAll());

            SelectedCustomer = Customers.First();
        }

        /// <summary>
        /// Est-ce que la commande de débit pour s'exécuter?
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Vrai s'il </returns>
        private bool CanDebit(string obj)
        {
            return true;
        }

        private void DebitFromAccount(string obj)
        {
            throw new NotImplementedException();
        }

        private bool CanAddCredit(string obj)
        {
            return true;
        }

        private void CreditToAccount(string obj)
        {
            throw new NotImplementedException();
        }

        private void AddNewCustomer(object o)
        {
            var c = new Customer { FirstName = "Undefined", LastName = "Undefined" };
            Customers.Add(c);
            SelectedCustomer = c;
        }
    }
}
