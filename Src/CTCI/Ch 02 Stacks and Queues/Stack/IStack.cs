﻿namespace CTCI.Ch_02_Stacks_and_Queues.Stack
{
    public interface IStack<T>
    {
        int Count { get; }

        void Push(T item);
        T Pop();
        T Peek();
    }
}