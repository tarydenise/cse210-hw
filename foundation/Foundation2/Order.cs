using System;
using System.Collections.Generic;

public class Order
{
    private List<(Product, int)> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<(Product, int)>();
        _customer = customer;
    }

    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (var (product, quantity) in _products)
        {
            total += product.GetPricePerUnit() * quantity;
        }

        if (_customer.GetAddress().GetCountry().ToLower() == "usa")
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var (product, quantity) in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()}), Qty: {quantity}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        return label;
    }
}