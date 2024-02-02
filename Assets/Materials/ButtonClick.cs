using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public InputField velocityInput;
    //public InputField heightInput;
    public BallForce ballController;

    // Hàm để gọi khi button được nhấn
    public void OnButtonClick()
    {
        // Lấy dữ liệu từ input fields
        float velocity = float.Parse(velocityInput.text);
        //float height = float.Parse(heightInput.text);

        // Gọi hàm ApplyForce từ script quả bóng và truyền dữ liệu vào
        ballController.SetInitialValues(velocity);
        ballController.ApplyHorizontalForce();
        ballController.ApplyVerticalForce();
        //ApplyHorizontalForce(); lực phát động
        //ApplyVerticalForce(); trọng lực
    }
}
