﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSocket.Plugs
{
    /// <summary>
    /// 表示服务器插件基础类
    /// </summary>
    public abstract class PlugBase : IPlug
    {
        /// <summary>
        /// 会话连接成功后触发
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        protected virtual void OnConnected(object sender, IContenxt context)
        {
        }


        /// <summary>
        /// SSL验证完成后触发
        /// 如果起用了SSL，验证通过后才可以往客户端发送数据
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        protected virtual void OnSSLAuthenticated(object sender, IContenxt context)
        {
        }

        /// <summary>
        /// 收到请求后触发
        /// 此方法在先于协议中间件的Invoke方法调用
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        protected virtual void OnRequested(object sender, IContenxt context)
        {
        }

        /// <summary>
        /// 会话断开后触发
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        protected virtual void OnDisconnected(object sender, IContenxt context)
        {
        }

        /// <summary>
        /// 服务异常事件
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="exception">异常</param>
        protected virtual void OnException(object sender, Exception exception)
        {
        }

        #region IPlug
        /// <summary>
        /// 会话连接成功后触发
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        void IPlug.OnConnected(object sender, IContenxt context)
        {
            this.OnConnected(sender, context);
        }

        /// <summary>
        /// SSL验证后触发
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        void IPlug.OnAuthenticated(object sender, IContenxt context)
        {
            this.OnSSLAuthenticated(sender, context);
        }


        /// <summary>
        /// 收到请求后触发
        /// 此方法在先于协议中间件的Invoke方法调用
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        void IPlug.OnRequested(object sender, IContenxt context)
        {
            this.OnRequested(sender, context);
        }



        /// <summary>
        /// 会话断开后触发
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="context">上下文</param>
        void IPlug.OnDisconnected(object sender, IContenxt context)
        {
            this.OnDisconnected(sender, context);
        }


        /// <summary>
        /// 服务异常事件
        /// </summary>
        /// <param name="sender">发生者</param>
        /// <param name="exception">异常</param>
        void IPlug.OnException(object sender, Exception exception)
        {
            this.OnException(sender, exception);
        }
        #endregion
    }
}
