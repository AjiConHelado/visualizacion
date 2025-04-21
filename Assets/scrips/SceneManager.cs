using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SceneManager : MonoBehaviour
{

    public CinemachineVirtualCameraBase inicioCam;
    public CinemachineVirtualCameraBase pistolaCam;
    public CinemachineVirtualCameraBase pistolapartesCam;
    public CinemachineVirtualCameraBase capsulaCam;
    public CinemachineVirtualCameraBase cuerpoCam;
    public CinemachineVirtualCameraBase adnCam;
    [SerializeField] GameObject UIadn;
    [SerializeField] GameObject UIinicio;
    [SerializeField] GameObject UIcapsula;
    [SerializeField] GameObject UIpistola;
    [SerializeField] GameObject UIpartespistola;
    [SerializeField] GameObject UIcuerpo;
    [SerializeField] GameObject cuerpo;
    void Update()
    {

    }

   public void escenacapsula()
    {
        UIpartespistola.SetActive(false);
        UIcuerpo.SetActive(false);
        UIpistola.SetActive(false);
        UIinicio.SetActive(false);
        UIcapsula.SetActive(true);
        cuerpo.SetActive(false);
        UIadn.SetActive(false);
        adnCam.Priority = 0;
        inicioCam.Priority = 0;
        capsulaCam.Priority = 10;
        pistolaCam.Priority = 0;
        pistolapartesCam.Priority = 0;
        cuerpoCam.Priority = 0;

    }
    public void MainMenu()
    {
        UIpartespistola.SetActive(false);
        UIcuerpo.SetActive(false);
        UIpistola.SetActive(false);
        UIcapsula.SetActive(false);
        UIinicio.SetActive(true);
        UIadn.SetActive(false);
        adnCam.Priority = 0;
        inicioCam.Priority = 10;
        capsulaCam.Priority = 0;
        pistolaCam.Priority = 0;
        pistolapartesCam.Priority = 0;
        cuerpoCam.Priority = 0;
    }
    public void escenapistola()
    {
        UIpartespistola.SetActive(false);
        UIcuerpo.SetActive(false);
        UIpistola.SetActive(true);
        UIinicio.SetActive(false);
        UIcapsula.SetActive(false);
        UIadn.SetActive(false);
        adnCam.Priority = 0;
        inicioCam.Priority = 0;
        capsulaCam.Priority = 0;
        pistolaCam.Priority = 10;
        pistolapartesCam.Priority = 0;
        cuerpoCam.Priority = 0;
    }
    public void escenapartespistola()
    {
        UIcuerpo.SetActive(false);
        UIpistola.SetActive(false);
        UIpartespistola.SetActive(true);
        UIinicio.SetActive(false);
        UIcapsula.SetActive(false);
        UIadn.SetActive(false);
        adnCam.Priority = 0;
        inicioCam.Priority = 0;
        capsulaCam.Priority = 0;
        pistolaCam.Priority = 0;
        pistolapartesCam.Priority = 10;
        cuerpoCam.Priority = 0;
    }
    public void escenacuerpo()
    {
        UIpartespistola.SetActive(false);
        UIcuerpo.SetActive(true);
        UIpistola.SetActive(false);
        UIinicio.SetActive(false);
        UIcapsula.SetActive(false);
        UIadn.SetActive(false);
        adnCam.Priority = 0;
        inicioCam.Priority = 0;
        capsulaCam.Priority = 0;
        pistolaCam.Priority = 0;
        cuerpoCam.Priority = 10;
        pistolapartesCam.Priority = 0;
        cuerpo.SetActive(true);

    }
    public void escenaAdn()
    {
        UIpartespistola.SetActive(false);
        UIcuerpo.SetActive(false);
        UIpistola.SetActive(false);
        UIinicio.SetActive(false);
        UIcapsula.SetActive(false);
        UIadn.SetActive(true);
        adnCam.Priority = 10;
        inicioCam.Priority = 0;
        capsulaCam.Priority = 0;
        pistolaCam.Priority = 0;
        cuerpoCam.Priority = 0;
        pistolapartesCam.Priority = 0;
        cuerpo.SetActive(false);

    }


}
