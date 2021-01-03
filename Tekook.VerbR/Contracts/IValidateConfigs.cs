﻿using System.Collections.Generic;

namespace Tekook.VerbR.Contracts
{
    /// <summary>
    /// Contract for a config validator.
    /// </summary>
    public interface IValidateConfigs
    {
        /// <summary>
        /// Determinates if the config is valid.
        /// </summary>
        /// <param name="config">The configuration to validate.</param>
        /// <returns>true if the config is valid.</returns>
        bool IsValid(object config);

        /// <summary>
        /// Determinates if the config is valid.
        /// </summary>
        /// <param name="config">The configruation to validate.</param>
        /// <param name="errors">Output of <see cref="IValidationError"/> which occurred during validation.</param>
        /// <returns>true if the config is valid.</returns>
        bool IsValid(object config, out IEnumerable<IValidationError> errors);
    }
}