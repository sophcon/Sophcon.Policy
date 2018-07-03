using System;

namespace Sophcon.Policy
{
    public enum PolicyStatus
    {
        None, Failure, Success
    }

    public class PolicyResult
    {
        private PolicyResult() { }

        public static PolicyResult Success = new PolicyResult { Status = PolicyStatus.Success };
        public PolicyStatus Status { get; set; }
        public string FailureMessage { get; set; }
        public bool Correctable { get; set; } = false;
        public string CorrectableAction { get; set; }
        public static PolicyResult Failure(string message, bool correctable = false, string correctableAction = default(string)) =>
            new PolicyResult
            {
                Status = PolicyStatus.Failure,
                FailureMessage = message,
                Correctable = correctable,
                CorrectableAction = correctableAction
            };

    }

}
