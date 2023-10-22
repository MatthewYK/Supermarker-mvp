﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PaymodeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource =new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelPayMode;
            this.view.SetPayModeListBildingSource(payModeBindingSource);
            loadAllPayModeList();
            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PaymodeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                   
                    repository.Edit(payMode);
                    view.Message = "PayMode edited Successfuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added succesfuly";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            view.IsSuccessful = true;
            loadAllPayModeList();
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";

        }
        private void CancelAction (object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                var PayMode = (PaymodeModel)payModeBindingSource.Current;
                repository.Delete(PayMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay mode delected succesfully";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Pay mode delected su";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PaymodeModel)payModeBindingSource.Current;
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName= payMode.Name;
            view.PayModeObservation = payMode.Observation;
            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
            payModeList= repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource= payModeList;
        }
    }
}
