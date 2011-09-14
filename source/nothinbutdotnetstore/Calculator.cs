﻿using System;
using System.Data;
using System.Linq;

namespace nothinbutdotnetstore
{
    public interface ICalculate
    {
        int add(int first, int second);
    }

    public class Calculator : ICalculate
    {
        IDbConnection connection;

        public Calculator(IDbConnection connection)
        {
            this.connection = connection;
        }

        public int add(int first, int second)
        {
            ensure_all_are_positive(first, second);

          connection.Open();

            return first + second;
        }

        void ensure_all_are_positive(params int[] numbers)
        {
            if (numbers.All(x => x > 0)) return;

            throw new ArgumentException();
        }
      void ensure_connection_is_configured(IDbConnection testConnection)
      {
        if (testConnection == null)
          throw new ApplicationException("Connection was not defined");
        if (string.IsNullOrEmpty(testConnection.ConnectionString)) ;
        throw new ApplicationException("Connection is not configured");
      }
    }
}