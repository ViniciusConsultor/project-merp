﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Views.Stammdaten.Product;
using WpfApplication1.DataAccess;
using WpfApplication1.DataAccess.Stammdaten.Product;
using WpfApplication1.Model.Stammdaten;

namespace WpfApplication1.ViewModel.Stammdaten.Product {
    public class AllProductsViewModel : WorkspaceViewModel
    {
        private ProductRepository _productRepository;
        private ProductViewModel _productViewModel;
        private ObservableCollection<ProductView> _products;

        public AllProductsViewModel()
        {
            _productRepository = new ProductRepository();
            _productViewModel = new ProductViewModel();
        }

        public ObservableCollection<ProductView> Products
        {
            get
            {
                if (_products == null || _products.Count == 0)
                {
                    _products = new ObservableCollection<ProductView>(_productRepository.ProductsList);
                }
                return _products;
            }
        } 
        
    }
}