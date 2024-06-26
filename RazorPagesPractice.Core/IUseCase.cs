﻿namespace RazorPagesPractice.Core
{
    public interface IUseCase<in TRequest, out TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
