using System;
using System.Collections.Generic;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

namespace MISLiveMed.Utils.SystemData
{
    public static class SystemInfo
    {
        public static string GetSystemInfo()
        {
            string str1 = "";
            ManagementObject managementObject1 = SystemInfo.GetManagementObject("Processor");
            string str2 = str1 + "Processor (Id):" + SystemInfo.GetValue(managementObject1, "ProcessorId") + ";" + "Processor (Name):" + SystemInfo.GetValue(managementObject1, "Name") + ";" + "Processor (Manufacturer):" + SystemInfo.GetValue(managementObject1, "Manufacturer") + ";" + "Processor (UniqueId):" + SystemInfo.GetValue(managementObject1, "UniqueId") + ";" + "Processor (PartNumber):" + SystemInfo.GetValue(managementObject1, "PartNumber") + ";" + "Processor (SerialNumber):" + SystemInfo.GetValue(managementObject1, "SerialNumber") + ";" + "Processor (MaxClockSpeed):" + SystemInfo.GetValue(managementObject1, "MaxClockSpeed") + ";";
            string str3 = "";
            ManagementObject managementObject2 = SystemInfo.GetManagementObject("BaseBoard");
            string str4 = str3 + "BaseBoard (Product):" + SystemInfo.GetValue(managementObject2, "Product") + ";" + "BaseBoard (Manufacturer):" + SystemInfo.GetValue(managementObject2, "Manufacturer") + ";" + "BaseBoard (Name):" + SystemInfo.GetValue(managementObject2, "Name") + ";" + "BaseBoard (SerialNumber):" + SystemInfo.GetValue(managementObject2, "SerialNumber") + ";" + "BaseBoard (Model):" + SystemInfo.GetValue(managementObject2, "Model") + ";" + "BaseBoard (PartNumber):" + SystemInfo.GetValue(managementObject2, "PartNumber") + ";";
            string str5 = "";
            ManagementObject systemDiskDrive = SystemInfo.GetSystemDiskDrive();
            string str6 = str5 + "DiskDrive (Name):" + SystemInfo.GetValue(systemDiskDrive, "Name") + ";" + "DiskDrive (SerialNumber):" + SystemInfo.GetValue(systemDiskDrive, "SerialNumber") + ";" + "DiskDrive (Model):" + SystemInfo.GetValue(systemDiskDrive, "Model") + ";" + "DiskDrive (Manufacturer):" + SystemInfo.GetValue(systemDiskDrive, "Manufacturer") + ";" + "DiskDrive (Signature):" + SystemInfo.GetValue(systemDiskDrive, "Signature") + ";" + "DiskDrive (Size):" + SystemInfo.GetValue(systemDiskDrive, "Size") + ";" + "DiskDrive (DeviceId):" + SystemInfo.GetValue(systemDiskDrive, "DeviceId") + ";" + "DiskDrive (Caption):" + SystemInfo.GetValue(systemDiskDrive, "Caption") + ";" + "DiskDrive (InterfaceType):" + SystemInfo.GetValue(systemDiskDrive, "InterfaceType") + ";";
            string str7 = "";
            ManagementObject managementObject3 = SystemInfo.GetManagementObject("VideoController");
            string str8 = str7 + "VideoController (Name):" + SystemInfo.GetValue(managementObject3, "Name") + ";" + "VideoController (VideoProcessor):" + SystemInfo.GetValue(managementObject3, "VideoProcessor") + ";" + "VideoController:" + SystemInfo.GetValue(managementObject3, "Caption") + ";";
            string str9 = "";
            ManagementObject managementObject4 = SystemInfo.GetManagementObject("BIOS");
            string str10 = str9 + "BIOS (Version):" + SystemInfo.GetValue(managementObject4, "Version") + ";" + "BIOS (Caption):" + SystemInfo.GetValue(managementObject4, "Caption") + ";" + "BIOS (SerialNumber):" + SystemInfo.GetValue(managementObject4, "SerialNumber") + ";" + "BIOS (SMBIOSBIOSVersion):" + SystemInfo.GetValue(managementObject4, "SMBIOSBIOSVersion") + ";" + "BIOS (IdentificationCode):" + SystemInfo.GetValue(managementObject4, "IdentificationCode") + ";" + "BIOS (Manufacturer):" + SystemInfo.GetValue(managementObject4, "Manufacturer") + ";" + "BIOS (ReleaseDate):" + SystemInfo.GetValue(managementObject4, "ReleaseDate") + ";";
            string str11 = "";
            ManagementObject managementObject5 = SystemInfo.GetManagementObject("OperatingSystem");
            string str12 = str11 + "OperatingSystem (SerialNumber):" + SystemInfo.GetValue(managementObject5, "SerialNumber") + ";" + "OperatingSystem (Version):" + SystemInfo.GetValue(managementObject5, "Version") + ";" + "OperatingSystem (GUID):" + SystemInfo.GetMachineGuid();
            return str2 + str4 + str6 + str8 + str10 + str12;
        }

        public static string GetMachineGuid()
        {
            string name1 = "SOFTWARE\\Microsoft\\Cryptography";
            string name2 = "MachineGuid";
            using (RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey registryKey2 = registryKey1.OpenSubKey(name1))
                    return ((registryKey2 != null ? registryKey2.GetValue(name2) : throw new KeyNotFoundException(string.Format("Key Not Found: {0}", (object)name1))) ?? throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", (object)name2))).ToString();
            }
        }

        public static string GetHardwareID()
        {
            ManagementObject managementObject1 = SystemInfo.GetManagementObject("BIOS");
            ManagementObject managementObject2 = SystemInfo.GetManagementObject("Processor");
            ManagementObject managementObject3 = SystemInfo.GetManagementObject("BaseBoard");
            SystemInfo.GetManagementObject("OperatingSystem");
            ManagementObject systemDiskDrive = SystemInfo.GetSystemDiskDrive();
            return BitConverter.ToString(new SHA512Managed().ComputeHash(Encoding.UTF8.GetBytes("Processor_Id=" + SystemInfo.GetValue(managementObject2, "ProcessorId") + ";Processor_Name=" + SystemInfo.GetValue(managementObject2, "Name") + ";Processor_Manufacturer=" + SystemInfo.GetValue(managementObject2, "Manufacturer") + ";Processor_SerialNumber=" + SystemInfo.GetValue(managementObject2, "SerialNumber") + ";Processor_MaxClockSpeed=" + SystemInfo.GetValue(managementObject2, "MaxClockSpeed") + ";Processor_NumberOfCores=" + SystemInfo.GetValue(managementObject2, "NumberOfCores") + ";BaseBoard_Product=" + SystemInfo.GetValue(managementObject3, "Product") + ";BaseBoard_Manufacturer=" + SystemInfo.GetValue(managementObject3, "Manufacturer") + ";BaseBoard_SerialNumber=" + SystemInfo.GetValue(managementObject3, "SerialNumber") + ";BIOS_SerialNumber=" + SystemInfo.GetValue(managementObject1, "SerialNumber") + ";BIOS_Manufacturer=" + SystemInfo.GetValue(managementObject1, "Manufacturer") + ";DiskDrive_SerialNumber=" + SystemInfo.GetValue(systemDiskDrive, "SerialNumber") + ";DiskDrive_Model=" + SystemInfo.GetValue(systemDiskDrive, "Model") + ";")), 0).Trim().Replace("-", "");
        }

        private static string GetValue(ManagementObject moObject, string property)
        {
            try
            {
                return moObject[property] != null ? moObject[property].ToString() : "NotFound";
            }
            catch (Exception ex)
            {
                return "NotFound";
            }
        }

        private static ManagementObject GetManagementObject(string TableName)
        {
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("Select * from Win32_" + TableName).Get().GetEnumerator())
            {
                if (enumerator.MoveNext())
                    return (ManagementObject)enumerator.Current;
            }
            return (ManagementObject)null;
        }

        private static ManagementObject GetSystemDiskDrive()
        {
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID='" + Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2) + "'"))
            {
                foreach (ManagementObject managementObject1 in managementObjectSearcher.Get())
                {
                    foreach (ManagementObject managementObject2 in managementObject1.GetRelated("Win32_DiskPartition"))
                    {
                        using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObject2.GetRelated("Win32_DiskDrive").GetEnumerator())
                        {
                            if (enumerator.MoveNext())
                                return (ManagementObject)enumerator.Current;
                        }
                    }
                }
            }
            return (ManagementObject)null;
        }

        private static string GetProperty(string wmiClass, string wmiProperty)
        {
            string str = "";
            foreach (ManagementObject instance in new ManagementClass("Win32_" + wmiClass).GetInstances())
            {
                try
                {
                    if (instance[wmiProperty] != null)
                    {
                        str = instance[wmiProperty].ToString();
                        break;
                    }
                    break;
                }
                catch
                {
                }
            }
            return str;
        }

        public static string GetOSFriendlyName()
        {
            string empty = string.Empty;
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().GetEnumerator())
            {
                if (enumerator.MoveNext())
                    empty = enumerator.Current["Caption"].ToString();
            }
            return empty;
        }

        public static bool IsUserAdministrator()
        {
            try
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsElevated => WindowsIdentity.GetCurrent().Owner.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid);

        public static string LocalIPAddress()
        {
            string str = "";
            foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    str = address.ToString();
                    break;
                }
            }
            return str;
        }

        public static List<string> GetAllIPAddress()
        {
            List<string> stringList = new List<string>();
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    Console.WriteLine(networkInterface.Name);
                    foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
                            stringList.Add(unicastAddress.Address.ToString());
                    }
                }
            }
            if (!stringList.Contains(SystemInfo.LocalIPAddress()))
                stringList.Add(SystemInfo.LocalIPAddress());
            return stringList;
        }

        public static string MachineName() => Environment.MachineName;
    }
}
