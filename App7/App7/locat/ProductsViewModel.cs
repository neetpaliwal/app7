using System;
using System.Collections.Generic;
using System.Text;

namespace App7.locat
{
    public class ProductsViewModel
    {
        private readonly IProductsService _productsService;
        //private readonly ITextToSpeech _textToSpeech;

        public IEnumerable<Product> Products { get; set; }

        public ProductsViewModel()//, ITextToSpeech textToSpeech)
        {
            _productsService = new ProductsService();
            //_productsService = productsService;
            // _textToSpeech = textToSpeech;
            DownloadProducts();
            //_textToSpeech.Speak("IoC and DI");
        }
        public void DownloadProducts()
        {
            Products = _productsService.Getproducts();
        }
    }
}
