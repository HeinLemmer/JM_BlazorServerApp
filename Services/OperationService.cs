using JendaMarkBlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JendaMarkBlazorApp.Services
{
    class OperationService
    {
        private List<Operation> operations = new List<Operation>();
        private int operationIdCounter = 1;

        public List<Operation> GetOperations()
        {
            return operations;
        }

        public Operation GetOperation(int operationId)
        {
            return operations.FirstOrDefault(o => o.OperationID == operationId);
        }

        public int GetNextOperationId()
        {
            return operationIdCounter;
        }

        public Operation AddOperation(Operation operation)
        {
            operation.OperationID = operationIdCounter++;
            operations.Add(operation);
            return operation;
        }

        public void RemoveOperation(int operationId)
        {
            var operationToRemove = GetOperation(operationId);
            if (operationToRemove != null)
            {
                operations.Remove(operationToRemove);
            }
        }
    }
}

