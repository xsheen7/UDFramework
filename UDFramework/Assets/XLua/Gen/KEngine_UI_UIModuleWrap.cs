#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class KEngineUIUIModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(KEngine.UI.UIModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 17, 10, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreLoadUIWindow", _m_PreLoadUIWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OpenWindow", _m_OpenWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToggleWindow", _m_ToggleWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OpenDynamicWindow", _m_OpenDynamicWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CallUI", _m_CallUI);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CallDynamicUI", _m_CallDynamicUI);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseWindow", _m_CloseWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyAllWindows", _m_DestroyAllWindows);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseAllWindows", _m_CloseAllWindows);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsOpen", _m_IsOpen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLoad", _m_IsLoad);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTopUI", _m_GetTopUI);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadWindow", _m_LoadWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReloadWindow", _m_ReloadWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetUIOrder", _m_ResetUIOrder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUIOrder", _m_SetUIOrder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyWindow", _m_DestroyWindow);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadingUICount", _g_get_LoadingUICount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UIRoot", _g_get_UIRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UICamera", _g_get_UICamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MainUIRoot", _g_get_MainUIRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NormalUIRoot", _g_get_NormalUIRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HeadInfoUIRoot", _g_get_HeadInfoUIRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CommonAtlases", _g_get_CommonAtlases);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UiBridge", _g_get_UiBridge);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UIWindows", _g_get_UIWindows);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dict", _g_get_dict);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "LoadingUICount", _s_set_LoadingUICount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CommonAtlases", _s_set_CommonAtlases);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UiBridge", _s_set_UiBridge);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UIWindows", _s_set_UIWindows);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dict", _s_set_dict);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 7, 3);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sortOrderMainUI", _g_get_sortOrderMainUI);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sortOrderNormal", _g_get_sortOrderNormal);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sortOrderTips", _g_get_sortOrderTips);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnInitEvent", _g_get_OnInitEvent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnOpenEvent", _g_get_OnOpenEvent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnCloseEvent", _g_get_OnCloseEvent);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnInitEvent", _s_set_OnInitEvent);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnOpenEvent", _s_set_OnOpenEvent);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnCloseEvent", _s_set_OnCloseEvent);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KEngine.UI.UIModule gen_ret = new KEngine.UI.UIModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.UI.UIModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreLoadUIWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<object>(L, 4))) 
                {
                    string _uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    bool _isOnInit = LuaAPI.lua_toboolean(L, 3);
                    object[] _args = translator.GetParams<object>(L, 4);
                    
                        KEngine.UI.UILoadState gen_ret = gen_to_be_invoked.PreLoadUIWindow( _uiTemplateName, _isOnInit, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    bool _isOnInit = LuaAPI.lua_toboolean(L, 3);
                    
                        KEngine.UI.UILoadState gen_ret = gen_to_be_invoked.PreLoadUIWindow( _uiTemplateName, _isOnInit );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    
                        KEngine.UI.UILoadState gen_ret = gen_to_be_invoked.PreLoadUIWindow( _uiTemplateName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.UI.UIModule.PreLoadUIWindow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    object[] _args = translator.GetParams<object>(L, 3);
                    
                        KEngine.UI.UILoadState gen_ret = gen_to_be_invoked.OpenWindow( _uiName, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToggleWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    object[] _args = translator.GetParams<object>(L, 3);
                    
                    gen_to_be_invoked.ToggleWindow( _uiName, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenDynamicWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    string _instanceName = LuaAPI.lua_tostring(L, 3);
                    object[] _args = translator.GetParams<object>(L, 4);
                    
                        KEngine.UI.UILoadState gen_ret = gen_to_be_invoked.OpenDynamicWindow( _uiName, _instanceName, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallUI(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    System.Action<KEngine.UI.UIController, object[]> _callback = translator.GetDelegate<System.Action<KEngine.UI.UIController, object[]>>(L, 3);
                    object[] _args = translator.GetParams<object>(L, 4);
                    
                    gen_to_be_invoked.CallUI( _uiName, _callback, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallDynamicUI(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    System.Action<KEngine.UI.UIController, object[]> _callback = translator.GetDelegate<System.Action<KEngine.UI.UIController, object[]>>(L, 3);
                    object[] _args = translator.GetParams<object>(L, 4);
                    
                    gen_to_be_invoked.CallDynamicUI( _uiName, _callback, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.CloseWindow( _uiName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyAllWindows(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DestroyAllWindows(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseAllWindows(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CloseAllWindows(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsOpen(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsOpen( _uiName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLoad(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsLoad( _uiName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTopUI(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    KEngine.UI.PanelType _panelType;translator.Get(L, 2, out _panelType);
                    
                        KEngine.UI.UIController gen_ret = gen_to_be_invoked.GetTopUI( _panelType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    bool _openWhenFinish = LuaAPI.lua_toboolean(L, 3);
                    object[] _args = translator.GetParams<object>(L, 4);
                    
                        KEngine.UI.UILoadState gen_ret = gen_to_be_invoked.LoadWindow( _uiName, _openWhenFinish, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReloadWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _uiTemplateName = LuaAPI.lua_tostring(L, 2);
                    KCallback _callback = translator.GetDelegate<KCallback>(L, 3);
                    
                        UnityEngine.Coroutine gen_ret = gen_to_be_invoked.ReloadWindow( _uiTemplateName, _callback );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetUIOrder(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetUIOrder(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUIOrder(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    KEngine.UI.UIController _uiBase = (KEngine.UI.UIController)translator.GetObject(L, 2, typeof(KEngine.UI.UIController));
                    
                    gen_to_be_invoked.SetUIOrder( _uiBase );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    bool _destroyImmediate = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.DestroyWindow( _uiName, _destroyImmediate );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _uiName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.DestroyWindow( _uiName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.UI.UIModule.DestroyWindow!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, KEngine.UI.UIModule.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadingUICount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.LoadingUICount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortOrderMainUI(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, KEngine.UI.UIModule.sortOrderMainUI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortOrderNormal(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, KEngine.UI.UIModule.sortOrderNormal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortOrderTips(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, KEngine.UI.UIModule.sortOrderTips);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UIRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UIRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UICamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UICamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MainUIRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MainUIRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NormalUIRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.NormalUIRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HeadInfoUIRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.HeadInfoUIRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CommonAtlases(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CommonAtlases);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UiBridge(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UiBridge);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UIWindows(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UIWindows);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnInitEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, KEngine.UI.UIModule.OnInitEvent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnOpenEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, KEngine.UI.UIModule.OnOpenEvent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnCloseEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, KEngine.UI.UIModule.OnCloseEvent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.dict);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LoadingUICount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LoadingUICount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CommonAtlases(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CommonAtlases = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UiBridge(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UiBridge = (KEngine.UI.GUIBridge)translator.GetObject(L, 2, typeof(KEngine.UI.GUIBridge));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UIWindows(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UIWindows = (System.Collections.Generic.Dictionary<string, KEngine.UI.UILoadState>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, KEngine.UI.UILoadState>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnInitEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    KEngine.UI.UIModule.OnInitEvent = translator.GetDelegate<System.Action<KEngine.UI.UIController>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnOpenEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    KEngine.UI.UIModule.OnOpenEvent = translator.GetDelegate<System.Action<KEngine.UI.UIController>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnCloseEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    KEngine.UI.UIModule.OnCloseEvent = translator.GetDelegate<System.Action<KEngine.UI.UIController>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.UI.UIModule gen_to_be_invoked = (KEngine.UI.UIModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.dict = (System.Collections.Generic.Dictionary<System.Type, KEngine.UI.UIController>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<System.Type, KEngine.UI.UIController>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
