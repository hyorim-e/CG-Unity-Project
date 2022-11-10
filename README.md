# CG-Unity-Project
컴그 유니티 프로젝트
3D프로젝트(URP아님)

ㅡㅡ효림 11/05 ~ 11/06 1:36ㅡㅡ
https://www.youtube.com/watch?v=5rMkh9sl2bM
똑같이 따라했으나 작동안함
https://issuetracker.unity3d.com/issues/urp-renderingcommandbuffer-invalid-pass-index-errors-when-opening-urp-sample-scenes
콘솔에 해당 오류 발생
다시 작동 시 오류 발생안함, 여전히 pixelate 작동안함

프로젝트 새로 만들어가며 해봤는데 여전히 작동안함
용량 확보 위해 실패한 프로젝트 폴더 삭제 시도, 폴더 삭제가 안됨
https://extrememanual.net/8390
어딜가도 자꾸 이렇게 관리자 소유자 변경 어쩌구하는데 해결안됨
(여기서 1시간 넘게 날림)
https://m.blog.naver.com/50after/220847787251
여기서 드디어 해결.
하위 폴더들 하나씩 삭제하면 삭제됨(날린 시간 개허무함)

URP말고 그냥 3D 프로젝트로 생성하니까 작동함

작동되는 기능에 슬라이더 값 .value 응용했으나 실패

https://youtu.be/L5wniFiuUbY
활용해 슬라이더 값 .value 응용 성공!!

https://youtu.be/jg2I2odw51M
실시간으로 포스트 프로세싱 조절하는 법 찾음!
5:16까지 따라함
5:17 코드부터 다시 시작

ㅡㅡ효림 언젠지 모름ㅡㅡ
https://youtu.be/jg2I2odw51M
코드부터 따라해 실시간으로 값 변경하는 방법 배움.
응용하여 버튼에 따라 변경될 수 있게 함.

ㅡㅡ효림 11/10 ~5:31ㅡㅡ
https://www.youtube.com/watch?v=5rMkh9sl2bM&t=69s
에서 픽셀화 후처리를 버튼에 따라 on, off되게 하고 싶었는데
OnRenderImage라는 함수가 if 안에 넣거나, pixelate라는 함수로 씌우거나 하면 작동이 안됨..
Update에서 동작하는 함수도 아니고, 영상의 코드대로 작성하면 그냥 작동됨.
그리고 이 픽셀화 코드를 post-processing 기능을 작성한 PostProcessingEffects 스크립트에 붙여넣으면,
PostProcessingEffects 스크립트는 빈 오브젝트에 넣어 오브젝트화 시킨거라서
메인카메라에 붙이는게 아님.
픽셀화 후처리 기능은 해당 스크립트가 카메라에 붙어있지 않으면 동작을 안함. 화면이 안나옴.
메인카메라에 붙은 상태로 그냥 실행했을 때는 슬라이더에 처음부터 기능이 붙어 나와서 다른 기능이랑 충돌함..
어떤 버튼을 누름에 따라 하나의 기능만 슬라이더에 붙어야함.
1시간 정도 요리조리 코드 고쳐보고, 머리 싸맨 결과
해당 코드를 작성한 스크립트 PixelateCam이 메인 카메라에 붙으니까,
아예 픽셀화 후처리 전용 카메라를 따로 만들어서 거기에 PixelateCam 스크립트를 붙이고
메인 카메라에서는 PixelateCam 스크립트를 떼버리기.
PostProcessingEffects 스크립트에서 픽셀화 버튼을 누르면 이 카메라가 활성화되고, 다른 버튼을 누르면 비활성화 되게 하면 되지 않을까?
> 실행됨!! 아주잘됨~~ 카메라 활성화, 비활성화돼서 바뀔 때도 화면 깜빡인다거나 그런거 하나도 없음!

Next >> 성휘 프로젝트랑 붙이기 
