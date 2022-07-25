# TextMeshPro란?

> TextMeshPro is the ultimate text solution for Unity. It’s the perfect replacement for Unity’s UI Text and the legacy Text Mesh.
>

빠른 속도, 적은 메모리 사용, 최적화 유리, 커스텀 가능

# TextMeshPro 사용하기

### 1. 준비

- Package Manager에서 TMP 다운로드
- 사용하고싶은 폰트 다운로드
- 무료 폰트 다운로드 사이트

  [눈누](https://noonnu.cc/)


### 2. Font Asset

- Window-TextMeshPro-Font Asset Creator
- Source Font File : 폰트 에셋에 사용할 폰트 파일(.ttf)
- Sampling Point Size
    - Auto Sizing : 자동으로 Atlas 크기에 맞춰 폰트 크기 설정
    - Custom Size :한 글자당 차지할 크기
- Padding : Atlas에 등록되는 텍스트 사이의 거리
- Packing Method
    - Fast : 더 작은 글꼴 크기로 설정 될 수 있음
    - Optimum : 모든 문자에 맞는 최대 글꼴 크기로 설정
- Atlas Resolution : Atlas 크기
- Character Set : Atlas에 등록되는 텍스트 설정 방법
- Render Mode
    - SMOOTH_HINTED : 힌팅 O, 안티 앨리어싱 O (라인이 부드러움)
    - SMOOTH : 힌팅 X, 안티 앨리어싱 O (동적으로 사용할 때 렌더링 가장 빠름)
    - RASTER_HINTED : 힌팅 O, 안티 앨리어싱 X (가장 선명)
    - RASTER : 힌팅 X, 안티 앨리어싱 X
    - SDF(Signed Distance Field) : 위의 비트맵 방식과 다르게 거리에 따라 선명도를 계산하여 보여주는 방식
    - 힌팅 : 글자 크기가 변하더라도 힌트를 참고하여 모양을 약간 변화시켜 글자를 뚜렷하게 보이도록 하는 기술

- Get Kerning Pairs : 특정 문자 간 거리를 조정하여 최적화해주는 기능이지만 대부분의 폰트에 없음
- 모든 한글 추가 하는 법

  Character Set : Custom Range / 44032-55203


### 3. Text Tags

- <sup> 위 첨자 </sup>
- <sub> 아래 첨자 </sub>
- <size=35> 폰트 크기 35로 설정 </size>
- <size=+10> 폰트 크기 10 크게 <size=+10>
- <size=-10> 폰트 크기 10 작게 <size=-10>
- <#000000> 폰트 색상 </color>

**[출처]** [유니티(Unity) - Textmesh Pro(텍스트 메쉬 프로) 한글 사용법](https://blog.naver.com/cdw0424/221641217203)

**[출처]** [[Unity Basic Skills] 08. UGUI - TextMeshPro-Text](https://www.youtube.com/watch?v=S_Vd-EqT9rI)