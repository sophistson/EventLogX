﻿Public Class FrmThinClient

    Private ThisEv As ApiEventlogXWinform

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ThisEv = New ApiEventlogXWinform(Me, _
                                         LstLogsOwn, LstLogsOther, LstSourcesOwn, LstSourcesOther, _
                                         TxtLogName, TxtSourceName, _
                                         ApiEventlogXWinform.ConfirmLevelList.DEL_ALL_SWITCH_ALL_CREATE_ALL) _
                                                                       With { _
                                                                                    .BtnDelLog = BtnDelLog, _
                                                                                 .BtnDelSource = BtnDelSource, _
                                                                                .BtnLogToOther = BtnLogToOther, _
                                                                                  .BtnLogtoOwn = BtnLogtoOwn, _
                                                                                 .BtnNewSource = BtnNewSource, _
                                                                             .BtnSourceToOther = BtnSourceToOther, _
                                                                               .BtnSourceToOwn = BtnSourceToOwn , _
                                                                                   .BtnRefresh = BtnRefresh _
                                                                            }
   End Sub

End Class
