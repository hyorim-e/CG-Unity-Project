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
