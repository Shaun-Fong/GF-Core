//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityEngine;

namespace GF.Runtime
{
    /// <summary>
    /// 游戏框架组件抽象类。
    /// </summary>
    public abstract class GameFrameworkComponent : MonoBehaviour
    {
        /// <summary>
        /// 游戏框架组件初始化。
        /// </summary>
        protected virtual void Awake()
        {
            ComponentInitialized();
        }

        /// <summary>
        /// 游戏框架组件更新轮询
        /// </summary>
        private void Update()
        {
            ComponentUpdate(Time.deltaTime, Time.unscaledDeltaTime);
        }

        /// <summary>
        /// 关闭并清理所有游戏框架模块
        /// </summary>
        private void OnDestroy()
        {
            GameFrameworkEntry.Shutdown();
        }

        /// <summary>
        /// 初始化组件
        /// </summary>
        protected virtual void ComponentInitialized()
        {
            GameEntry.RegisterComponent(this);
        }

        /// <summary>
        /// 轮询更新组件
        /// </summary>
        /// <param name="elapseSeconds"></param>
        /// <param name="realElapseSeconds"></param>
        protected virtual void ComponentUpdate(float elapseSeconds, float realElapseSeconds)
        {
            GameFrameworkEntry.Update(elapseSeconds, realElapseSeconds);
        }
    }
}
