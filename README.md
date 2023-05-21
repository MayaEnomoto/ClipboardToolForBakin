# ClipboardToolForBakin

This is a support tool for copying and pasting the Talk (conversation), Message, and Notes event panels of RPG Developer Bakin.  
It is intended to be used for writing scenarios and then copying and pasting them into Bakin as a conversation panel.

You can also clipboard from Bakin, but only the three types of event panels mentioned above can be copied.  
(The data size and other information will be unknown, so the process will exit when there is a panel that is not supported.)  
Depending on the state of the copied data, this application may fail.

Also, the data structure of the clipboard is based on the output, so unexpected errors may occur, especially if there is an update on the Bakin side.  
Please be sure to back up your project before use.

In most cases, we have confirmed that there is no problem by forcibly closing the event editor while editing, even if an unexpected format error occurs, but it may be necessary to forcibly close Bakin itself.

---

RPG Developer BakinのTalk(conversation), Message, Notesのイベントパネルを良しなにコピペする為のサポートツールです。  
シナリオを書いてから会話パネルとして纏めてBakinにコピペしたりする使い方を想定しています。

Bakin側からクリップボードで取り込むこともできますが、前述の3種類のイベントパネル以外は取り込めません。  
（データサイズ等が不明な状態となる為、サポート外のパネルがあった時点で処理を抜けます。コピーした状態によっては本アプリがエラーとなります。）

また、クリップボードのデータ構造は、出力結果からの推測である為、予期しないエラー（特にBakin側のアップデートがあった場合等）が発生する事があります。  
必ずプロジェクトのバックアップを取ってから利用してください。

殆どの場合、想定外のフォーマットエラーになっても編集中のイベントエディタを強制的に閉じる事で問題ない事は確認していますが、Bakin本体を強制終了しなければならなくなる事もあり得ます。
