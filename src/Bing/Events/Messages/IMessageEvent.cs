﻿namespace Bing.Events.Messages
{
    /// <summary>
    /// 消息事件
    /// </summary>
    public interface IMessageEvent : IEvent
    {
        /// <summary>
        /// 消息名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 事件数据
        /// </summary>
        object Data { get; set; }        

        /// <summary>
        /// 回调
        /// </summary>
        string Callback { get; set; }
    }
}
