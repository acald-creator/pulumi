// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Mypkg
{
    public static class FuncWithDefaultValue
    {
        /// <summary>
        /// Check codegen of functions with default values.
        /// </summary>
        public static Task<FuncWithDefaultValueResult> InvokeAsync(FuncWithDefaultValueArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<FuncWithDefaultValueResult>("mypkg::funcWithDefaultValue", args ?? new FuncWithDefaultValueArgs(), options.WithDefaults());

        /// <summary>
        /// Check codegen of functions with default values.
        /// </summary>
        public static Output<FuncWithDefaultValueResult> Invoke(FuncWithDefaultValueInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<FuncWithDefaultValueResult>("mypkg::funcWithDefaultValue", args ?? new FuncWithDefaultValueInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Check codegen of functions with default values.
        /// </summary>
        public static Output<FuncWithDefaultValueResult> Invoke(FuncWithDefaultValueInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<FuncWithDefaultValueResult>("mypkg::funcWithDefaultValue", args ?? new FuncWithDefaultValueInvokeArgs(), options.WithDefaults());
    }


    public sealed class FuncWithDefaultValueArgs : global::Pulumi.InvokeArgs
    {
        [Input("a", required: true)]
        public string A { get; set; } = null!;

        [Input("b")]
        public string? B { get; set; }

        public FuncWithDefaultValueArgs()
        {
            B = "b-default";
        }
        public static new FuncWithDefaultValueArgs Empty => new FuncWithDefaultValueArgs();
    }

    public sealed class FuncWithDefaultValueInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("a", required: true)]
        public Input<string> A { get; set; } = null!;

        [Input("b")]
        public Input<string>? B { get; set; }

        public FuncWithDefaultValueInvokeArgs()
        {
            B = "b-default";
        }
        public static new FuncWithDefaultValueInvokeArgs Empty => new FuncWithDefaultValueInvokeArgs();
    }


    [OutputType]
    public sealed class FuncWithDefaultValueResult
    {
        public readonly string R;

        [OutputConstructor]
        private FuncWithDefaultValueResult(string r)
        {
            R = r;
        }
    }
}
