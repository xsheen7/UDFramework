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
    public class KEngineAssetBundleLoaderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(KEngine.AssetBundleLoader);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushLoadedAsset", _m_PushLoadedAsset);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Bundle", _g_get_Bundle);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Load", _m_Load_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PreLoadManifest", _m_PreLoadManifest_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "NewAssetBundleLoaderEvent", _g_get_NewAssetBundleLoaderEvent);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "NewAssetBundleLoaderEvent", _s_set_NewAssetBundleLoaderEvent);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					KEngine.AssetBundleLoader gen_ret = new KEngine.AssetBundleLoader();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetBundleLoader constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2)&& translator.Assignable<KEngine.LoaderMode>(L, 3)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate _callback = translator.GetDelegate<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2);
                    KEngine.LoaderMode _loaderMode;translator.Get(L, 3, out _loaderMode);
                    
                        KEngine.AssetBundleLoader gen_ret = KEngine.AssetBundleLoader.Load( _url, _callback, _loaderMode );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate _callback = translator.GetDelegate<KEngine.AssetBundleLoader.CAssetBundleLoaderDelegate>(L, 2);
                    
                        KEngine.AssetBundleLoader gen_ret = KEngine.AssetBundleLoader.Load( _url, _callback );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    
                        KEngine.AssetBundleLoader gen_ret = KEngine.AssetBundleLoader.Load( _url );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetBundleLoader.Load!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreLoadManifest_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool _isForce = LuaAPI.lua_toboolean(L, 1);
                    
                    KEngine.AssetBundleLoader.PreLoadManifest( _isForce );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 0) 
                {
                    
                    KEngine.AssetBundleLoader.PreLoadManifest(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to KEngine.AssetBundleLoader.PreLoadManifest!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.AssetBundleLoader gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    object[] _args = translator.GetParams<object>(L, 3);
                    
                    gen_to_be_invoked.Init( _url, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.AssetBundleLoader gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushLoadedAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                KEngine.AssetBundleLoader gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Object _getAsset = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.PushLoadedAsset( _getAsset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Bundle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                KEngine.AssetBundleLoader gen_to_be_invoked = (KEngine.AssetBundleLoader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Bundle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NewAssetBundleLoaderEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, KEngine.AssetBundleLoader.NewAssetBundleLoaderEvent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NewAssetBundleLoaderEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    KEngine.AssetBundleLoader.NewAssetBundleLoaderEvent = translator.GetDelegate<System.Action<string>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
