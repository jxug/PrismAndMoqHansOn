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

続く
