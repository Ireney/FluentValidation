namespace FluentValidation.Results {
    using System.Collections.Generic;

    public interface IValidationResult {
        bool IsValid { get; }
        IList<ValidationFailure> Errors { get; }
    }
}