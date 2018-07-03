using System;
using System.Collections.Generic;
using System.Text;

namespace Sophcon.Policy.Extensions
{
    public static class PolicyExtensions
    {
        public static IPolicy<T> SetSubject<T>(this IPolicy<T> policy, T subject)
        {
            policy.Subject = subject;
            return policy;
        }

        public static bool IsSuccess(this PolicyResult result) =>
            result == PolicyResult.Success;

        public static PolicyResult And<T>(this PolicyResult left, IPolicy<T> policy) =>
            left.IsSuccess()
                ? policy.Evaluate()
                : left;

        public static PolicyResult Or<T>(this PolicyResult left, IPolicy<T> policy) =>
            left.IsSuccess()
                ? left
                : policy.Evaluate();
    }
}
