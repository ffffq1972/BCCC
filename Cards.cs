using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BCCC
{
	public class newCard
	{
		public string Academy;
		public string Name;
		public string Explanation;
		/// <summary>
		/// 0 : 딜
		/// 1 : 탱<br/>
		/// 2 : 힐
		/// 3 : 서폿
		/// </summary>
		public int Position;
		/// <summary>
		/// 스페셜카드는 100
		/// </summary>
		public int HP;
		/// <summary>
		/// 스페셜카드는 4
		/// </summary>
		public int Reach;
		public int Damage;
		public int Cost;
		public Texture2D img;
		public float width;
		public float height;
		public Vector2 pos;
		public float scale;
		public float angle;
		public newCard(string Academy, string Name, string Explanation, int Position, int HP, int Reach, int Damage, int Cost)
		{
			this.Academy = Academy;
			this.Name = Name;
			this.Explanation = Explanation;
			this.Position = Position;
			this.HP = HP;
			this.Reach = Reach;
			this.Damage = Damage;
			this.Cost = Cost;
		}
	}
	internal class Cards
	{
		public class Abydos
		{ 
			// 아비도스
			public static newCard Shiroko_Sunaookami;
			public static newCard Shiroko_Sunaookami_special;
			public static newCard Hoshino_Takanashi;
			public static newCard Serika_Kuromi;
			public static newCard Nonomi_Ijayomi;
			public static newCard Ayane_Okusora;

			public static void Init()
			{
				Shiroko_Sunaookami = new newCard("아비도스", "스나오오카미 시로코", "상대 필드의 [STRIKER] 1장에게 2의 데미지를 준다.", 0, 5, 2, 2, 2);
				Shiroko_Sunaookami_special = Shiroko_Sunaookami; // 그냥 노말카드랑 똑같은데 이미지만 다른거임. 그냥 이쁨.
				Hoshino_Takanashi = new newCard("아비도스", "타카나시 호시노", "상대 필드의 1, 2의 포지션에 있는 [STRIKER]에게 2 데미지를 주고 이 카드의 [HP]를 2 회복한다.", 1, 6, 1, 2, 4);
				Serika_Kuromi = new newCard("아비도스", "쿠로미 세리카", "자신의 [TRASH]에 있는 [SHOT] 카드 1장을 패로 가져온다. 그 후 카드는 한번 더 [ACTION] 할 수 있다.", 0, 5, 3, 1, 2);
				Nonomi_Ijayomi = new newCard("아비도스", "이자요미 노노미", "상대 필드의 1, 2, 3의 포지션에 있는 [STRIKER]에게 2 데미지를 준다.", 0, 5, 1, 3, 5);
				Ayane_Okusora = new newCard("아비도스", "오소쿠라 아야네", "자신의 [STRIKER] 카드를 3장 까지 선택하고 [HP]를 3씩 회복하고 1의 방어력을 얻는다. (방어력은 [HP]로 취급되며 데미지를 입을 시 사라진다)", 2, 100, 4, 0, 4);
			}
		}

		public class Gehenna
		{ 
			// 게헨나
			public static newCard Aru_Rikuhachima;
			public static newCard Aru_Rikuhachima_special;
			public static newCard Mutsuki_Isagi;
			public static newCard Kayoko_Onikata;
			public static newCard Haruka_Igusa;
			public static newCard Juri_Ushimaki;
			public static newCard Fuuka_Aikiyo;
			// 선도부
			public static newCard Hina_Sorasaki;
			public static newCard Iori_Shiromi;
			public static newCard Chinatsu_Hinomiya;
			public static newCard Ako_Amau;
		}

		public class Millennium
		{
			// 밀레니엄
			public static newCard Aris_Tendo;
			public static newCard Yuzu_Hanaoka;
			public static newCard Midori_Saiba;
			public static newCard Momoi_Saiba;
			public static newCard Utaha_Shiraishi;
			public static newCard Hibiki_Nekozuka;
			// 세미나
			public static newCard Noa_Ushino;
			public static newCard Yuuka_Hayase;
			public static newCard Koyuki_Kurosaki;
		}

		public class Trinity
		{
			// 트리니티
			public static newCard Hihumi_Azitani;
			public static newCard Azusa_Shirazu;
			public static newCard Koharu_Shimoe;
			public static newCard Mika_Misono;
			public static newCard Nagisa_Kirihuzi;
			public static newCard Hanako_Urawa;
			// 정의실현부
			public static newCard Tsurigi_Kenzaki;
			public static newCard Hasumi_Hanekawa;
			public static newCard Ichika_Nazamasa;
			public static newCard Mashiro_Shizuyama;
		}

		public class Schale
		{
			// 샬레
			public static newCard Arona; // 파란봉투
			public static newCard Sora; // 마빡왕
		}

		public class ETC
		{
			// 시바세키 라멘
			public static newCard Shiba_Master; // 마스터 시바 ㄹ

			// 무소속
			public static newCard Work_Foreman; // 용역 반장
			public static newCard Thugs; // 불량배
		}

		public class Special
		{
			// 스페셜
			public static newCard Obstacle; // 엄폐물
			public static newCard Cap; // 무지 캡모자
			public static newCard Abydos_BD; // 기초 전술 교육 BD-아비도스
			public static newCard Gehenna_BD; // 기초 전술 교육 BD-게헨나
			public static newCard Badge; // 서벌 금속 뱃지
			public static newCard Amulet; // 교통 안전 부적
			public static newCard Glove; // 스포츠용 장갑
			public static newCard Ikazuchi; // 천둥이
			public static newCard Sneekers; // 핑크 스니커즈
			public static newCard Keystonel; //	기동석
			public static newCard Sportbag; // 방수 스포츠백
			public static newCard Medical_Kit; // 응급키트

			// 발포
			public static newCard Shoot; // 발포!
		}

		public class Za_Warudo
		{
			// 더 월드
			public static newCard ZA_WARUDO; // 자 와루도!!! 토키오 토마레!!!
		}
	}
}
