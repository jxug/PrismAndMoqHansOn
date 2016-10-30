# WhyPrismSession
This article in the session "Why Prism for Xamarin.Forms".

# リファクタリング簡易手順書  

1. App.csクラスの親クラスをPrismApplicationクラスに変更  
2. App.csクラスのコンストラクタをコメントアウト  
3. App.csクラスにRegisterTypesメソッドを実装し、NavigationPage・MainPage・TextSpeechPageを追加  
4. App.csクラスにOnInitializedメソッドを実装し、"NavigationPage/MainPage"へ画面遷移を実装する  
5. MainPageViewModelにNavigationCommandを宣言する  
6. MainPage.xaml.csのイベントハンドラをコメントアウトする  
7. MainPage.xamlのボタンクリックイベントハンドラをCommandのバインドに変更する  
8. MainPage.xamlのBindingContextへViewModelを設定しているコードを削除する  
9. MainPage.xamlにViewModelLocator.AutowireViewModel="True"を宣言する  
10. MainPageViewModelTest.csにExecuteNavigationCommandテストメソッドを追加する  
11. ExecuteNavigationCommandメソッドでNavigationCommandのIsNotNullとCanExecuteのIsTrueをテストする  
-> テストを実行 -> エラー  
12. MainPageViewModelでNavigationCommandのCommandを割り当てNavigateメソッドを追加する  
-> テストを実行 -> 成功  
13. MainPageViewModelでINavigationServiceをインジェクションし、フィールドに保持する  
14. MainPageViewModelTestでINavigationServiceのMockの追加とNavigationCommandの実行と実行結果の確認コードを追加  
-> テストを実行 -> エラー
15. MainPageViewModelのNavigationメソッドにTextSpeechPageへの遷移を追加  
-> テストを実行 -> 成功  
-> デバッグ実行 -> ダイアログが出ないで画面遷移をすることを確認する  
16. MainPageViewModelにIConfirmNavigationAwareインターフェースを追加  
17. 上記インターフェースのメソッド３つを実装し、OnNavigatedFromとOnNavigatedToは空実装に、CanNavigateAsyncは例外をスローするようにしておく  
18. IPageDialogServiceをMainPageViewModelのコンストラクタでインジェクションし、フィールドに保持しておく  
19. MainPageViewModelTestのExecuteNavigationCommandテストメソッドでIPageDialogServiceのモックをコンストラクタへインジェクションする  
-> テストを実行 -> 成功（壊していないことを確認する）  
20. MainPageViewModelTestにNaivateToTextSpeechPageWhenPressedOkテストメソッドを追加しテストコードの追加  
-> テストを実行 -> エラー
21. MainPageViewModelTestにNaivateToTextSpeechPageWhenPressedCancelテストメソッドを追加しテストコードの追加  
-> テストを実行 -> エラー  
22. MainPageViewModelのCanNavigateAsyncでダイアログの実装  
-> テストを実行 -> 成功  
-> デバッグ実行 -> 確認ダイアログが正しく動作することを確認する  
23. TextSpeechPageViewModelTestのテストを実行する  
-> Xamarin.Forms.Initが呼ばれていないエラーが発生することを確認する  
24. TextSpeechPageViewModelを開き、Speechメソッドの実装を全削除  
25. TextSpeechPageViewModelのコンストラクタにITextToSpeechServiceをインジェクションしフィールドへ保持  
26. ITextToSpeechServiceTestを開き、テストコードの実装  
-> テストを実行 -> エラー  
27. TextSpeechPageViewModelのSpeechメソッドを実装  
-> テストを実行 -> 成功  
28. カバレッジが取得できるなら取得してみる（オプション）  
-> SpeechCommandがカバレッジを通過していないのを確認する  
29. テストコードを修正し、コマンドを実行するように修正する  
-> テストを実行 -> 成功＆カバレッジ100%  
30. TextSpeechPageのBindingContextへViewModelを設定している箇所を削除し、ViewModelLocatorに変更する  
-> デバッグ実行 -> すべて正しく動作することを確認する  
