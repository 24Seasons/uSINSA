## 오딘 사용법

1. 에셋스토어에서 Odin을 Import한다.
2. OdinInspector를 사용하려는 클래스에 `SerializedMonoBehaviour` 상속받는다.
3. 사용하려는 attribute를 해당 field나 property앞에 추가한다.

*** 이후 field와 property는 변수로 통일

##Attribute 설명

### OdinSerialize, ShowInInspector, HideInInspector

  OdinSerialize 와 ShowInInspector는 둘 다 변수를 인스펙터창에 보여주지만 OdinSerialize는 변경한 값이 저장되고 ShowInInspector는 저장되지않는다.

### ShowIf(조건)
  조건에 따라 변수를 보여주거나 가릴 수 있다.
### PropertyOrder(정수)
  인스펙터에서 변수를 보여줄 순서를 지정할 수 있다. 기본값은 모두 0이며 -도 가능하다.
### FilePath(Extensions =”.확장자")
  파일을 드래그앤 드롭 하면 경로를 가져온다. 확장자를 지정할 경우 해당 확장자를 가진 파일의 경로만 가져온다.
### AssetList
  모든 에셋을 불러온다.
### ColorPalette
  컬러 팔레트를 보여준다. 색상의 조합을 임의로 정해둘 수 있다.
### Button
  함수 위에 작성하며 클릭할 경우 해당 함수를 호출한다.
### PreviewField
  object의 미리보기를 제공한다.
### Required
  해당 변수에 값이 할당되지 않으면 경고를 표시한다.
### AssetsOnly
  에셋에 있는(씬 말고) 오브젝트만 넣을 수 있다.
### HorizontalGroup/VerticalGroup/TapGroup/FoldoutGroup/BoxGroup
  인스펙터의 그룹을 나눌 수 있다. 매개변수로 폴더구조의 string값을 사용한다.

### LabelText(레이블)
  변수명이 들어가는 자리에 대체 텍스트를 보여줄 수 있다.
### ListDrawerSettings
  리스트를 추가, 삭제할 때 실행되는 함수를 지정할 수 있다.
### ValidateInput
  해당 변수에 들어갈 값의 유효성을 검사하는 함수를 지정할 수 있다.
### OnValueChanged
  변수 값이 변경될 때 실행되는 함수를 지정할 수 있다.
### InfoBox
  인스펙터창에 메시지를 보여줄 수 있다.

> 그 외 Attribute들은 [https://odininspector.com/attributes](https://odininspector.com/attributes) 찾아볼 수 있다.