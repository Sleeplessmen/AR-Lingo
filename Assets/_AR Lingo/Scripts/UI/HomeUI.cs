using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : MonoBehaviour
{
    [Header("Các màn hình (Panels)")]
    public GameObject panelHome; // Màn hình chờ
    public GameObject panelAR;   // Màn hình AR (trong suốt)

    [Header("Các nút bấm")]
    public Button btnScan; // Nút ở màn Home
    public Button btnBack; // Nút ở màn AR (để quay lại)

    void Start()
    {
        // 1. Thiết lập trạng thái ban đầu: Hiện Home, Ẩn AR
        panelHome.SetActive(true);
        panelAR.SetActive(false);

        // 2. Gán sự kiện cho các nút
        if (btnScan != null)
            btnScan.onClick.AddListener(MoCheDoAR);
        
        if (btnBack != null)
            btnBack.onClick.AddListener(QuayVeHome);
    }

    // Hàm chuyển sang chế độ AR
    void MoCheDoAR()
    {
        Debug.Log("Chuyển sang AR...");
        panelHome.SetActive(false); // Tắt Home
        panelAR.SetActive(true);    // Bật giao diện AR lên
        
        // (Sau này nếu cần bật/tắt chức năng nhận diện bề mặt thì viết thêm ở đây)
    }

    // Hàm quay về màn hình chờ
    void QuayVeHome()
    {
        Debug.Log("Quay về Home...");
        panelAR.SetActive(false); // Tắt AR
        panelHome.SetActive(true); // Hiện lại Home
    }
}