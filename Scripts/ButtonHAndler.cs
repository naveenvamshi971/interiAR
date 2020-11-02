MyHelloAR scriptMyHelloAR;
GameObject cubeGO;

public void ChangeObjectTypeToChair(){
    controllerGO = GameObject.Find(“Controller”);
    scriptMyHelloAR = controllerGO.GetComponent<MyHelloAR>();
    chairGO = GameObject.Find(“chair”);
    scriptMyHelloAR.AndyPlanePrefab = chairGO;
}
