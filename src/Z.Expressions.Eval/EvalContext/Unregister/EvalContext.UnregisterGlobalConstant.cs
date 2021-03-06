﻿// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Linq.Expressions;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters a global constant.</summary>
        /// <param name="aliases">The global constant name.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterGlobalConstant(params string[] aliases)
        {
            foreach (var alias in aliases)
            {
                ConstantExpression value;
                AliasGlobalConstants.TryRemove(alias, out value);
            }

            return this;
        }
    }
}