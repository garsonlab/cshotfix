
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_ThreadPriority_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ThreadPriority);

            field = type.GetField("Low", flag);
            app.RegisterCLRFieldGetter(field, get_Low_0);
            field = type.GetField("BelowNormal", flag);
            app.RegisterCLRFieldGetter(field, get_BelowNormal_1);
            field = type.GetField("Normal", flag);
            app.RegisterCLRFieldGetter(field, get_Normal_2);
            field = type.GetField("High", flag);
            app.RegisterCLRFieldGetter(field, get_High_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ThreadPriority());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ThreadPriority[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ThreadPriority instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ThreadPriority[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Low_0(ref object o)
        {
            return UnityEngine.ThreadPriority.Low;
        }
        static object get_BelowNormal_1(ref object o)
        {
            return UnityEngine.ThreadPriority.BelowNormal;
        }
        static object get_Normal_2(ref object o)
        {
            return UnityEngine.ThreadPriority.Normal;
        }
        static object get_High_3(ref object o)
        {
            return UnityEngine.ThreadPriority.High;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ThreadPriority();
            ins = (UnityEngine.ThreadPriority)o;
            return ins;
        }


    }
}
#endif
