﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace SportClub.Aids {
    public class GetMember {
        public static string Name<T>(Expression<Func<T, object>> ex) 
            => Safe.Run(()=>Name(ex.Body), string.Empty);

        public static string Name<T, TResult>(Expression<Func<T, TResult>> ex) 
            => Safe.Run(() => Name(ex.Body), string.Empty);

        public static string Name<T>(Expression<Action<T>> ex) 
            => Safe.Run(() => Name(ex.Body), string.Empty);

        public static string DisplayName<T>(Expression<Func<T, object>> ex) =>
            Safe.Run(() => {
                var name = Name(ex);
                var p = GetClass.Property<T>(name);
                var list = p?.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                if (list is null || list.Length < 1) return name;
                var a = list.Cast<DisplayNameAttribute>().Single();
                return a?.DisplayName ?? name;
            }, string.Empty);

        private static string Name(Expression ex) {
            var member = ex as MemberExpression;
            var method = ex as MethodCallExpression;
            var operand = ex as UnaryExpression;
            if (!(member is null)) return Name(member);
            if (!(method is null)) return Name(method);
            if (!(operand is null)) return Name(operand);
            return string.Empty;
        }

        private static string Name(MemberExpression ex) => ex?.Member.Name ?? string.Empty;

        private static string Name(MethodCallExpression ex) => ex?.Method.Name ?? string.Empty;

        private static string Name(UnaryExpression ex) {
            var member = ex?.Operand as MemberExpression;
            var method = ex?.Operand as MethodCallExpression;
            if (!(member is null)) return Name(member);
            if (!(method is null)) return Name(method);
            return string.Empty;
        }
    }
}