// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Controls;

namespace Wpf.Ui;

public interface IDialogDataContext
{
    /// <summary>
    /// 请求关闭委托
    /// </summary>
    event Action<object?>? RequestClose;

    /// <summary>
    /// 当对话框打开完成方法
    /// </summary>
    /// <param name="parameters">参数</param>
    void OnDialogOpened(object? parameters);

    /// <summary>
    /// 关闭中
    /// </summary>
    void OnDialogClosing(ContentDialogClosingEventArgs arg);
}