using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("mpt3sas log_info:");
                string code = Console.ReadLine();
                if (code.Length != 10)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Please Enter the right mpt3sas log_info:");
                    Console.WriteLine(" ");
                }
                else
                {
                    string makesureType = code.Substring(2, 1).ToUpper();
                    string WheredidOriginatorcomefrom = code.Substring(3, 1);
                    Console.WriteLine(" ");
                    Console.WriteLine("What code means:");
                    Console.WriteLine(" ");

                    switch (makesureType)
                    {
                        case "0":
                            Console.WriteLine("0x0: MPI_IOCLOGINFO_TYPE_NONE");
                            break;
                        case "1":
                            Console.WriteLine("0x1: MPI_IOCLOGINFO_TYPE_SCSI");
                            break;
                        case "2":
                            Console.WriteLine("0x2: MPI_IOCLOGINFO_TYPE_FC");
                            break;
                        case "3":
                            Console.WriteLine("0x3: MPI_IOCLOGINFO_TYPE_SAS");
                            break;
                        case "4":
                            Console.WriteLine("0x4: MPI_IOCLOGINFO_TYPE_ISCSI");
                            break;
                        case "F":
                            Console.WriteLine("0xF0000000: MPI_IOCLOGINFO_TYPE_MASK");
                            break;
                    }
                    switch (WheredidOriginatorcomefrom)
                    {
                        case "0":
                            Console.WriteLine("0x00: IOC_LOGINFO_ORIGINATOR_IOP ");
                            break;
                        case "1":
                            Console.WriteLine("0x01: IOC_LOGINFO_ORIGINATOR_PL");
                            break;
                        case "2":
                            Console.WriteLine("0x02: IOC_LOGINFO_ORIGINATOR_IR");
                            break;
                        case "F":
                            Console.WriteLine("0x0F: IOC_LOGINFO_ORIGINATOR_MASK");
                            break;
                    }

                    if (WheredidOriginatorcomefrom == "0")
                    {
                        string IOPErrorCode1 = code.Substring(5, 5).ToUpper();
                        string IOPErrorCode2 = code.Substring(5, 3).ToUpper();
                      
                        switch (IOPErrorCode1)
                        {
                            
                   
                            case "3E001":
                                Console.WriteLine("0x0003E001: IOP_LOGINFO_CODE_FWUPLOAD_UNKNOWN_IMAGE_TYPE");
                                Console.WriteLine(" ");
                                Console.WriteLine("Explanation: ImageType field contents were invalid.");
                                Console.WriteLine(" ");
                                break;
                            case "3E002":
                                Console.WriteLine("0x0003E002: IOP_LOGINFO_CODE_FWUPLOAD_WRONG_IMAGE_SIZE");
                                Console.WriteLine(" ");
                                Console.WriteLine("Explanation: ImageSize field in TCSGE was bad/offset in MfgPg 4 was wrong.");
                                Console.WriteLine(" ");
                                break;
                            case "3E003":
                                Console.WriteLine("0x0003E003: IOP_LOGINFO_CODE_FWUPLOAD_ENTIRE_FLASH_UPLOAD_FAILED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Error occurred while attempting to upload the entire flash.");
                                Console.WriteLine(" ");
                                break;
                            case "3E004":
                                Console.WriteLine("0x0003E004: IOP_LOGINFO_CODE_FWUPLOAD_REGION_UPLOAD_FAILED");
                                Console.WriteLine(" ");
                                Console.WriteLine("Explanation: Error occurred while attempting to upload single flash region.");
                                Console.WriteLine(" ");
                                break;
                            case "3E005":
                                Console.WriteLine("0x0003E005: IOP_LOGINFO_CODE_FWUPLOAD_DMA_FAILURE ");
                                Console.WriteLine(" ");
                                Console.WriteLine("Explanation: Problem occurred while DMAing FW to host memory.");
                                Console.WriteLine(" ");
                                break;
                            case "60001":
                                Console.WriteLine("0x00060001: IOP_LOGINFO_CODE_ENCL_MGMT_READ_ACTION_ERR0R");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Read action not supported for SEP message.");
                                Console.WriteLine(" "); 
                                break;
                            case "60002":
                                Console.WriteLine("0x00060002: IOP_LOGINFO_CODE_ENCL_MGMT_INVALID_BUS_ID_ERR0R");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Invalid Bus ID in SEP message.");
                                Console.WriteLine(" "); 
                                break;
                            case "70001":
                                Console.WriteLine("0x00070001: IOP_LOGINFO_CODE_TARGET_ASSIST_TERMINATED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Target Assist is terminated, e.g., " +
                                                  "due to bus reset occurring just as this command came in.");
                                Console.WriteLine(" "); 
                                break;
                            case "70002":
                                Console.WriteLine("0x00070002: IOP_LOGINFO_CODE_TARGET_STATUS_SEND_TERMINATED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Target Status Send is terminated, e.g., " +
                                                  "due to bus reset occurring just as this command came in.");
                                Console.WriteLine(" "); 
                                break;
                            case "70003":
                                Console.WriteLine("0x00070003: IOP_LOGINFO_CODE_TARGET_MODE_ABORT_ALL_IO");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Target Mode Abort for all I/Os " +
                                                  "due to Task Management command from host.");
                                Console.WriteLine(" "); 
                                break;
                            case "70004":
                                Console.WriteLine("0x00070004: IOP_LOGINFO_CODE_TARGET_MODE_ABORT_EXACT_IO");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Target Mode Abort for specific I/Os " +
                                                  "due to Task Management command from host.");
                                Console.WriteLine(" "); 
                                break;
                            case "70005":
                                Console.WriteLine("0x00070005: IOP_LOGINFO_CODE_TARGET_MODE_ABORT_EXACT_IO_REQ");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Target Mode Abort for Target Assist or " +
                                                  "Target Status Send due to Task Management command from host.");
                                Console.WriteLine(" "); 
                                break;
                            
                        }
                        switch (IOPErrorCode2)
                        {
                        case "100":
                            Console.WriteLine("0x00010000: IOP_LOGINFO_CODE_INVALID_SAS_ADDRESS");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Invalid SAS Address detected in Manufacturing Page 5.");
                            Console.WriteLine(" "); 
                            break;
                        case "200":
                            Console.WriteLine("0x00020000: IOP_LOGINFO_CODE_UNUSED2");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Not used.");
                            Console.WriteLine(" "); 
                            break;
                        case "300":
                            Console.WriteLine("0x00030000: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Not used.");
                            Console.WriteLine(" ");
                            break;
                        case "301":
                            Console.WriteLine("0x00030100: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_RT");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Route table entry not found.");
                            Console.WriteLine(" "); 
                            break;
                        case "302":
                            Console.WriteLine("0x00030200: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_PN");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Invalid page number.");
                            break;
                        case "303":
                            Console.WriteLine("0x00030300: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_FORM");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Invalid FORM.");
                            Console.WriteLine(" ");
                            break;
                        case "304":
                            Console.WriteLine("0x00030400: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_PT");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Invalid page type.");
                            Console.WriteLine(" "); 
                            break;
                        case "305":
                            Console.WriteLine("0x00030500: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_DNM");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Device not mapped.");
                            Console.WriteLine(" ");
                            break;
                        case "306":
                            Console.WriteLine("0x00030600: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_PERSIST");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Persistent page not found.");
                            Console.WriteLine(" "); 
                            break;
                        case "307":
                            Console.WriteLine("0x00030700: IOP_LOGINFO_CODE_CONFIG_INVALID_PAGE_DEFAULT");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Default page not found.");
                            Console.WriteLine(" "); 
                            break;
                        case "3E0":
                            if (IOPErrorCode1 == "3E001")
                            {
                                    break;
                            }
                            else
                            {
                                  Console.WriteLine("0x0003E000: IOP_LOGINFO_CODE_FWUPLOAD_NO_FLASH_AVAILABLE");
                                  Console.WriteLine(" "); 
                                  Console.WriteLine("Explanation: Tried to upload from flash, but there is none.");
                                  Console.WriteLine(" ");
                                }
                                      break;
                        case "400":
                            Console.WriteLine("0x00040000: IOP_LOGINFO_CODE_DIAG_MSG_ERROR");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: Diagnostic Buffer error detected.");
                            Console.WriteLine(" "); 
                            break;
                        case "500":
                            Console.WriteLine("0x00050000: IOP_LOGINFO_CODE_TASK_TERMINATED");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: I/O has been terminated as a result of Task Management. " +
                                              "This Task Management can also be generated internally by the firmware.");
                            Console.WriteLine(" "); 
                            break;
                        case "800":
                            Console.WriteLine("0x00080000: IOP_LOGINFO_CODE_LOG_TIMESTAMP_EVENT");
                            Console.WriteLine(" "); 
                            Console.WriteLine("Explanation: There is no explanation on manual");
                            Console.WriteLine(" "); 
                            break;

                        }
                    }
                    else if (WheredidOriginatorcomefrom == "1")
                    {
                        string PLErrorcode1 = code.Substring(5, 5).ToUpper(); 
                        string PLErrorcode2 = code.Substring(4, 6).ToUpper();
                        string PLErrorcode3 = code.Substring(4, 2).ToUpper(); 
                        string PLErrorcode4 = code.Substring(4, 3).ToUpper(); 
                        string PLErrorcode5 = code.Substring(6, 1);
                        string PLErrorcode6 = code.Substring(7, 1).ToUpper();
                        string PLErrorcode7 = code.Substring(7, 2).ToUpper();
                        string PLErrorcode8 = code.Substring(7, 3).ToUpper();
                        string PLErrorcode9 = code.Substring(8, 2).ToUpper();
                        
                        
                        switch(PLErrorcode1)
                        {
                            
                            
                            case "F0001":
                                Console.WriteLine("0x000F0001: PL_LOGINFO_CODE_CONFIG_PL_NOT_INITIALIZED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Error reading the Config Page: it is not initialized.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0100":
                                Console.WriteLine("0x000F0100: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_PT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Invalid page type.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0200":
                                Console.WriteLine("0x000F0200: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_NUM_PHYS");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Invalid number of phys.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0300":
                                Console.WriteLine("0x000F0300: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_NOT_IMP");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Case not handled.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0400":
                                Console.WriteLine("0x000F0400: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_NO_DEV");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: No device found.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0500":
                                Console.WriteLine("0x000F0500: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_FORM");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Invalid FORM.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0600":
                                Console.WriteLine("0x000F0600: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_PHY");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Invalid Phy.");
                                Console.WriteLine(" "); 
                                break;
                            case "F0700":
                                Console.WriteLine("0x000F0700: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE_NO_OWNER");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: No owner found.");
                                Console.WriteLine(" "); 
                                break;
                        }
                        switch (PLErrorcode2)
                        {
                            case "200000":
                                Console.WriteLine("0x00200000: PL_LOGINFO_CODE_ENCL_MGMT_SMP_FRAME_FAILURE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Cannot get SMP frame.");
                                Console.WriteLine(" "); 
                                break;
                            case "200010":
                                Console.WriteLine("0x00200010: PL_LOGINFO_CODE_ENCL_MGMT_SMP_READ_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Error occurred on SMP Read.");
                                Console.WriteLine(" "); 
                                break;
                            case "200020":
                                Console.WriteLine("0x00200020: PL_LOGINFO_CODE_ENCL_MGMT_SMP_WRITE_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Error occurred on SMP Write.");
                                Console.WriteLine(" "); 
                                break;
                            case "200040":
                                Console.WriteLine("0x00200040: PL_LOGINFO_CODE_ENCL_MGMT_NOT_SUPPORTED_ON_ENCL");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Enclosure Management services not available for this WWID.");
                                Console.WriteLine(" "); 
                                break;
                            case "200050":
                                Console.WriteLine("0x00200050: PL_LOGINFO_CODE_ENCL_MGMT_ADDR_MODE_NOT_SUPPORTED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Address Mode not supported.");
                                Console.WriteLine(" "); 
                                break;
                            case "200060":
                                Console.WriteLine("0x00200060: PL_LOGINFO_CODE_ENCL_MGMT_BAD_SLOT_NUM");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Invalid slot number in SEP Message.");
                                Console.WriteLine(" "); 
                                break;
                            case "200070":
                                Console.WriteLine("0x00200070: PL_LOGINFO_CODE_ENCL_MGMT_SGPIO_NOT_PRESENT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SGPIO not present/enabled.");
                                Console.WriteLine(" "); 
                                break;
                            case "200080":
                                Console.WriteLine("0x00200080: PL_LOGINFO_CODE_ENCL_MGMT_GPIO_NOT_CONFIGURED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: GPIO not configured.");
                                Console.WriteLine(" "); 
                                break;
                            case "200090":
                                Console.WriteLine("0x00200090: PL_LOGINFO_CODE_ENCL_MGMT_GPIO_FRAME_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: GPIO cannot allocate a frame.");
                                Console.WriteLine(" "); 
                                break;
                            case "2000A0":
                                Console.WriteLine("0x002000A0: PL_LOGINFO_CODE_ENCL_MGMT_GPIO_CONFIG_PAGE_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: GPIO failed config page request.");
                                Console.WriteLine(" "); 
                                break;
                            case "2000B0":
                                Console.WriteLine("0x002000B0: PL_LOGINFO_CODE_ENCL_MGMT_SES_FRAME_ALLOC_ERROR");
                                Console.WriteLine(" ");
                                Console.WriteLine("Explanation: Cannot get frame for SES command.");
                                Console.WriteLine(" "); 
                                break;
                            case "2000C0":
                                Console.WriteLine("0x002000C0: PL_LOGINFO_CODE_ENCL_MGMT_SES_IO_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: I/O execution error.");
                                Console.WriteLine(" "); 
                                break;
                            case "2000D0":
                                Console.WriteLine("0x002000D0: PL_LOGINFO_CODE_ENCL_MGMT_SES_RETRIES_EXHAUSTED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP I/O retries exhausted.");
                                Console.WriteLine(" "); 
                                break;
                            case "2000E0":
                                Console.WriteLine("0x002000E0: PL_LOGINFO_CODE_ENCL_MGMT_SMP_FRAME_ALLOC_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Cannot get frame for SMP command.");
                                Console.WriteLine(" "); 
                                break;
                            case "200100":
                                Console.WriteLine("0x00200100: PL_LOGINFO_DA_SEP_NOT_PRESENT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP not present when message was received.");
                                Console.WriteLine(" "); 
                                break;
                            case "200101":
                                Console.WriteLine("0x00200101: PL_LOGINFO_DA_SEP_SINGLE_THREAD_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Can only accept one message at a time.");
                                Console.WriteLine(" "); 
                                break;
                            case "200102":
                                Console.WriteLine("0x00200102: PL_LOGINFO_DA_SEP_ISTWI_INTR_IN_IDLE_STATE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: ISTWI interrupt received while in IDLE state.");
                                Console.WriteLine(" "); 
                                break;
                            case "200103":
                                Console.WriteLine("0x00200103: PL_LOGINFO_DA_SEP_RECEIVED_NACK_FROM_SLAVE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP NACK’d; it is busy.");
                                Console.WriteLine(" "); 
                                break;
                            case "200104":
                                Console.WriteLine("0x00200104: PL_LOGINFO_DA_SEP_DID_NOT_RECEIVE_ACK");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP did not receive. ACK (Last Rcvd Bit = 1).");
                                Console.WriteLine(" "); 
                                break;
                            case "200105":
                                Console.WriteLine("0x00200105: PL_LOGINFO_DA_SEP_BAD_STATUS_HDR_CHKSUM");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP stopped or sent bad chksum in Hdr.");
                                Console.WriteLine(" "); 
                                break;
                            case "200106":
                                Console.WriteLine("0x00200106: PL_LOGINFO_DA_SEP_STOP_ON_DATA");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP stopped while transferring data.");
                                Console.WriteLine(" "); 
                                break;
                            case "200107":
                                Console.WriteLine("0x00200107: PL_LOGINFO_DA_SEP_STOP_ON_SENSE_DATA");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP stopped while transferring sense data.");
                                Console.WriteLine(" "); 
                                break;
                            case "200108":
                                Console.WriteLine("0x00200108: PL_LOGINFO_DA_SEP_UNSUPPORTED_SCSI_STATUS_1");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP returned unknown SCSI status.");
                                Console.WriteLine(" "); 
                                break;
                            case "200109":
                                Console.WriteLine("0x00200109: PL_LOGINFO_DA_SEP_UNSUPPORTED_SCSI_STATUS_2");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP returned unknown SCSI status.");
                                Console.WriteLine(" "); 
                                break;
                            case "200110":
                                Console.WriteLine("0x00200110: PL_LOGINFO_DA_MUX_DID_NOT_ACCEPT_PORT_SETUP");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Mux didn't send an Ack (Last Rcvd Bit = 1) ");
                                Console.WriteLine("             since didn't accept port activated.");
                                Console.WriteLine(" "); 
                                break;
                            case "200111":
                                Console.WriteLine("0x00200111: PL_LOGINFO_DA_SEP_DID_NOT_SEND_ACK");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP did not send an Ack.");
                                Console.WriteLine(" "); 
                                break;
                            case "20010A":
                                Console.WriteLine("0x0020010A: PL_LOGINFO_DA_SEP_CHKSUM_ERROR_AFTER_STOP");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP returned bad chksum after STOP.");
                                Console.WriteLine(" "); 
                                break;
                            case "20010B":
                                Console.WriteLine("0x0020010B: PL_LOGINFO_DA_SEP_CHKSUM_ERROR_AFTER_STOP_GETDATA");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP returned bad chksum after STOP while getting data.");
                                Console.WriteLine(" "); 
                                break;
                            case "20010C":
                                Console.WriteLine("0x0020010C: PL_LOGINFO_DA_SEP_UNSUPPORTED_COMMAND");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP does not suppor t CDB opcode f/w location 1.");
                                Console.WriteLine(" "); 
                                break;
                            case "20010D":
                                Console.WriteLine("0x0020010D: PL_LOGINFO_DA_SEP_UNSUPPORTED_COMMAND_2");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP does not support CDB opcode f/w location 2.");
                                Console.WriteLine(" "); 
                                break;
                            case "020010E":
                                Console.WriteLine("0x0020010E: PL_LOGINFO_DA_SEP_UNSUPPORTED_COMMAND_3");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SEP does not suppor t CDB opcode f/w location 3.");
                                Console.WriteLine(" "); 
                                break;
                            case "020010F":
                                Console.WriteLine("0x0020010F: PL_LOGINFO_DA_MUX_DID_NOT_SEND_ACK");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Mux didn't send an Ack (Last Rcvd Bit = 1).");
                                Console.WriteLine(" "); 
                                break;

                        }
                        switch (PLErrorcode3)
                        {
                            case "01":
                                Console.WriteLine("0x00010000: PL_LOGINFO_CODE_OPEN_FAILURE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection to device.");
                                Console.WriteLine(" "); 
                                break;
                            case "02":
                                Console.WriteLine("0x00020000: PL_LOGINFO_CODE_INVALID_SGL");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "03":
                                Console.WriteLine("0x00030000: PL_LOGINFO_CODE_WRONG_REL_OFF_OR_FRAME_LENGTH");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "04":
                                Console.WriteLine("0x00040000: PL_LOGINFO_CODE_FRAME_XFER_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Error detected during frame transfer. " +
                                                  "See subcode for more detail.");
                                Console.WriteLine(" "); 
                                break;
                            case "05":
                                Console.WriteLine("0x00050000: PL_LOGINFO_CODE_TX_FM_CONNECTED_LOW");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" ");
                                break;
                            case "06":
                                Console.WriteLine("0x00060000: PL_LOGINFO_CODE_SATA_NON_NCQ_RW_ERR_BIT_SET");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Error detected on SATA non-NCQ drive automated read writes.");
                                Console.WriteLine("             Failing the command to host do some hardware cleanup issue target reset using internal task management.");
                                Console.WriteLine("             Note: Since this is a non - NCQ drive, hardware should only be using tag 0 for the device, ");
                                Console.WriteLine("                   and I / O to the device should be single - threaded.");
                                Console.WriteLine(" "); 
                                break;
                            case "07":
                                Console.WriteLine("0x00070000: PL_LOGINFO_CODE_SATA_READ_LOG_RECEIVE_DATA_ERR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "08":
                                Console.WriteLine("0x00080000: PL_LOGINFO_CODE_SATA_NCQ_FAIL_ALL_CMDS_AFTR_ERR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: An error occurred on a SATA NCQ drive; ");
                                Console.WriteLine("             Finishing all of the outstanding I / Os to the device, ");
                                Console.WriteLine("             the drive will abort the outstanding I / Os.");
                                Console.WriteLine(" "); 
                                break;
                            case "09":
                                Console.WriteLine("0x00090000: PL_LOGINFO_CODE_SATA_ERR_IN_RCV_SET_DEV_BIT_FIS");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "0A":
                                Console.WriteLine("0x000A0000: PL_LOGINFO_CODE_RX_FM_INVALID_MESSAGE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "0B":
                                Console.WriteLine("0x000B0000: PL_LOGINFO_CODE_RX_CTX_MESSAGE_VALID_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "0C":
                                Console.WriteLine("0x000C0000: PL_LOGINFO_CODE_RX_FM_CURRENT_FRAME_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "0D":
                                Console.WriteLine("0x000D0000: PL_LOGINFO_CODE_SATA_LINK_DOWN");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "0E":
                                Console.WriteLine("0x000E0000: PL_LOGINFO_CODE_DISCOVERY_SATA_INIT_W_IOS");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "0F":
                                Console.WriteLine("0x000F0000: PL_LOGINFO_CODE_CONFIG_INVALID_PAGE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" ");
                                break;
                            case "10":
                                Console.WriteLine("0x00100000: PL_LOGINFO_CODE_DSCVRY_SATA_INIT_TIMEOUT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "11":
                                Console.WriteLine("0x00110000: PL_LOGINFO_CODE_RESET");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Internal Task Management issued to reset the device.");
                                Console.WriteLine("             See subcode for more detail.");
                                Console.WriteLine(" "); 
                                break;
                            case "12":
                                Console.WriteLine("0x00120000: PL_LOGINFO_CODE_ABORT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Abort the command. See subcode for more detail.");
                                Console.WriteLine(" "); 
                                break;
                            case "13":
                                Console.WriteLine("0x00130000: PL_LOGINFO_CODE_IO_NOT_YET_EXECUTED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: I/O Aborted (host issued task management) before sent to target.");
                                Console.WriteLine(" "); 
                                break;
                            case "14":
                                Console.WriteLine("0x00140000: PL_LOGINFO_CODE_IO_EXECUTED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: I/O Aborted (host issued task management) after sent to target.");
                                Console.WriteLine(" "); 
                                break;
                            case "15":
                                Console.WriteLine("0x00150000: PL_LOGINFO_CODE_PERS_RESV_OUT_NOT_AFFIL_OWNER");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Finished persistent reserve out command, ");
                                Console.WriteLine("             but there is already an outstanding affiliation.");
                                Console.WriteLine(" "); 
                                break;
                            case "16":
                                Console.WriteLine("0x00160000: PL_LOGINFO_CODE_OPEN_TXDMA_ABORT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: There is no explanation on manual");
                                Console.WriteLine(" "); 
                                break;
                            case "17":
                                
                                if(makesureType == "3" && WheredidOriginatorcomefrom == "1")
                                {
                                    Console.WriteLine("0x00170000: PL_LOGINFO_CODE_IO_DEVICE_MISSING_DELAY_RETRY");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Device is missing and device missing delay timer option is enabled.");
                                    Console.WriteLine("             When the timer starts, an internal task management is sent to clean up the pending I / Os,");
                                    Console.WriteLine("             the I/Os are returned with this log info, and the host should retry these I / Os.");
                                    Console.WriteLine("             This log info is also sent when the I/O reply timer expires.");
                                    Console.WriteLine("0x31170000: SAS_LOGINFO_NEXUS_LOSS");
                                }
                                else
                                {
                                    Console.WriteLine("0x00170000: PL_LOGINFO_CODE_IO_DEVICE_MISSING_DELAY_RETRY");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Device is missing and device missing delay timer option is enabled.");
                                    Console.WriteLine("             When the timer starts, an internal task management is sent to clean up the pending I / Os,");
                                    Console.WriteLine("             the I/Os are returned with this log info, and the host should retry these I / Os.");
                                    Console.WriteLine("             This log info is also sent when the I/O reply timer expires.");
                                }
                                Console.WriteLine(" "); 
                                break;
                            case "18":
                                if (PLErrorcode4 == "181")
                                {
                                    Console.WriteLine("0x00181000: PL_LOGINFO_CODE_IO_CANCELLED_DUE_TO_CRC_ERR");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: I/O cancelled due to CRC error.");
                                }
                                else
                                {
                                    Console.WriteLine("0x00180000: PL_LOGINFO_CODE_IO_CANCELLED_DUE_TO_R_ERR");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Expalanation: I/O cancelled due to CRC error.");
                                }
                                Console.WriteLine(" "); 
                                break;
                            case "19":
                                {
                                    Console.WriteLine("0x00190000: PL_LOGINFO_CODE_IO_CANCELLED_DUE_TO_BREAK");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: I/O cancelled due to link broken.");
                                    Console.WriteLine(" "); 
                                    break;
                                }

                        }
                        switch (PLErrorcode5)
                        {
                            case "1":
                                Console.WriteLine("0x00001000: PL_LOGINFO_SUB_CODE_DSCVRY_SATA_INIT_TIMEOUT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Device failed SATA Init command. Aside from device failure,");
                                Console.WriteLine("             this can also be due to the link going down during SATA Init.");
                                Console.WriteLine("             Internal Task Management will then reset the link and retry SATA Init.");
                                Console.WriteLine(" "); 
                                break;
                            case "2":
                                Console.WriteLine("0x00002000: PL_LOGINFO_SUB_CODE_BREAK_ON_SATA_CONNECTION");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "3":
                                Console.WriteLine("0x00003000: PL_LOGINFO_SUB_CODE_BREAK_ON_STUCK_LINK");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: FW sends an internal task management reset to the link,");
                                Console.WriteLine("             if connection is already established when the link is stuck.");
                                Console.WriteLine(" "); 
                                break;
                            case "4":
                                Console.WriteLine("0x00004000: PL_LOGINFO_SUB_CODE_BREAK_ON_STUCK_LINK_AIP");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: FW sends an internal task management reset to the link, ");
                                Console.WriteLine("             if connection has not been established.");
                                Console.WriteLine(" "); 
                                break;
                            case "5":
                                Console.WriteLine("0x00005000: PL_LOGINFO_SUB_CODE_BREAK_ON_INCOMPLETE_BREAK_RCVD");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: There is no explanation on manual");
                                Console.WriteLine(" "); 
                                break;
                            case "6":
                                Console.WriteLine("0x00006000: PL_LOGINFO_SUB_CODE_BREAK_ON_STUCK_TX_DMA");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: I/O aborted since this transport has been stalled for 2.5 seconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "7":
                                Console.WriteLine("0x00007000: PL_LOGINFO_SUB_CODE_INVALID_SATA_TAG_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: An FIS that contained a tag that did not correspond to one of the device’s outstanding tags.");
                                Console.WriteLine(" "); 
                                break;
                        }
                        switch (PLErrorcode6)
                        {
                            case "1":
                                if (PLErrorcode2 == "200100" || PLErrorcode2 == "200101" ||
                                    PLErrorcode2 == "200102" || PLErrorcode2 == "200103" ||
                                    PLErrorcode2 == "200104" || PLErrorcode2 == "200105" ||
                                    PLErrorcode2 == "200106" || PLErrorcode2 == "200107" ||
                                    PLErrorcode2 == "200108" || PLErrorcode2 == "200109" ||
                                    PLErrorcode2 == "200110" || PLErrorcode2 == "200111" ||
                                    PLErrorcode2 == "20010A" || PLErrorcode2 == "20010B" ||
                                    PLErrorcode2 == "20010C" || PLErrorcode2 == "20010D" ||
                                    PLErrorcode2 == "20010E" || PLErrorcode2 == "20010F")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000100: PL_LOGINFO_SUB_CODE_OPEN_FAILURE");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Failed to open connection for reasons other than");
                                    Console.WriteLine("             the ones mentioned by the subcodes below.");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "2":
                                Console.WriteLine("0x00000200: PL_LOGINFO_SUB_CODE_INVALID_SGL");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Aborting the command due to invalid SGL detected.");
                                Console.WriteLine("             This may be caused by mismatch between amount of data moved and length requested.");
                                Console.WriteLine(" "); 
                                break;
                            case "3":
                                Console.WriteLine("0x00000300: PL_LOGINFO_SUB_CODE_WRONG_REL_OFF_OR_FRAME_LENGTH");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Firmware detected unexpected relative offset or wrong frame length.");
                                Console.WriteLine("             Aborting the command.");
                                Console.WriteLine(" "); 
                                break;
                            case "4":
                                Console.WriteLine("0x00000400: PL_LOGINFO_SUB_CODE_FRAME_XFER_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Frame transfer error occurred on data frame. This condition occurs if:");
                                Console.WriteLine("             • Connected becomes inactive during frame transmission.");
                                Console.WriteLine("             • NAK is received for a frame transmission.");
                                Console.WriteLine("             • ACK is not received before Connected goes inactive.");
                                Console.WriteLine("             • XRDY received to transmit DMA and the command is queued.");
                                Console.WriteLine("             The I / O is then aborted if it is not already in the abort list");
                                Console.WriteLine("             with an internal task management.This log info is then sent to the host.");
                                Console.WriteLine(" "); 
                                break;
                            case "5":
                                Console.WriteLine("0x00000500: PL_LOGINFO_SUB_CODE_TX_FM_CONNECTED_LOW");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Firmware tries to send query task to determine if the target actually got the command frame.");
                                Console.WriteLine("             This may happen if an open connection from host does not receive ACK/ NAK,");
                                Console.WriteLine("             possibly due to BREAK received.Upon completion of the task, ");
                                Console.WriteLine("             the I/ O will be aborted if it was not found or will be permitted to continue ");
                                Console.WriteLine("             if it was found on the target.");
                                Console.WriteLine(" "); 
                                break;
                            case "6":
                                Console.WriteLine("0x00000600: PL_LOGINFO_SUB_CODE_SATA_NON_NCQ_RW_ERR_BIT_SET");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "7":
                                Console.WriteLine("0x00000700: PL_LOGINFO_SUB_CODE_SATA_READ_LOG_RECEIVE_DATA_ERR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SATA Read Log Ext command failed. Following are the possible causes:");
                                Console.WriteLine("             • PIO Setup FIS received with SATA EndStatus bit 0 is set(0x01).");
                                Console.WriteLine("             • Device to Host register FIS Status field bits 5 and 0 are set(0x21)");
                                Console.WriteLine("             Target will be reset.");
                                Console.WriteLine(" "); 
                                break;
                            case "8":
                                Console.WriteLine("0x00000800: PL_LOGINFO_SUB_CODE_SATA_NCQ_FAIL_ALL_CMDS_AFTR_ERR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                Console.WriteLine(" "); 
                                break;
                            case "9":
                                Console.WriteLine("0x00000900: PL_LOGINFO_SUB_CODE_SATA_ERR_IN_RCV_SET_DEV_BIT_FIS");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: SATA Read Log Ext command arrived in an invalid frame type,");
                                Console.WriteLine("             not Device to Host Set Device Bits FIS.Target will be reset.");
                                Console.WriteLine(" "); 
                                break;
                            case "A":
                                Console.WriteLine("0x00000A00: PL_LOGINFO_SUB_CODE_RX_FM_INVALID_MESSAGE");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: XFER_RDY or RESPONSE received and the Rx Hardware");
                                Console.WriteLine("             indicates the tag / MID is not valid.Target will be reset.");
                                Console.WriteLine(" "); 
                                break;
                            case "B":
                                if (PLErrorcode9 == "01")
                                {
                                    Console.WriteLine("0x00000B01: PL_LOGINFO_SUB_CODE_RX_CTX_MESSAGE_INVALID_ERROR");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: I/O aborted since the valid frame is received and");
                                    Console.WriteLine("             the corresponding TAG is not validated.");
                                }
                                else
                                {
                                    Console.WriteLine("0x00000B00: PL_LOGINFO_SUB_CODE_RX_CTX_MESSAGE_VALID_ERROR");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: DATA frame was received with invalid tag/MID.");
                                    Console.WriteLine("             The SAS Specification says that the frame shall be discarded,");
                                    Console.WriteLine("             and firmware aborts the command with that tag.");
                                    Console.WriteLine("             Since firmware does not recognize the tag and which LUN it is for,");
                                    Console.WriteLine("             the target will be reset.");
                                }
                                Console.WriteLine(" "); 
                                break;
                            case "C":
                                Console.WriteLine("0x00000C00: PL_LOGINFO_SUB_CODE_RX_FM_CURRENT_FRAME_ERROR");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: This can happen if the target sends a Response or XFER_RDY frame too early,");
                                Console.WriteLine("             while the data transfer is still in progress. It can also happen in the ACK/ NAK timeout case.");
                                Console.WriteLine("             Firmware will reset the device.");
                                Console.WriteLine(" "); 
                                break;
                            case "D":
                                Console.WriteLine("0x00000D00: PL_LOGINFO_SUB_CODE_SATA_LINK_DOWN");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Resetting target because SATA link went down.");
                                Console.WriteLine(" "); 
                                break;
                            case "E":
                                if (PLErrorcode9 == "01")
                                {
                                    Console.WriteLine("0x00000E01: PL_LOGINFO_SUB_CODE_DISCOVERY_REMOTE_SEP_RESET");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Remote SEP needs to be reset.");
                                }
                                else
                                {
                                    Console.WriteLine("0x00000E00: PL_LOGINFO_SUB_CODE_DISCOVERY_SATA_INIT_W_IOS");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: SATA Init aborted outstanding I/Os to the device.");
                                    Console.WriteLine("             This device may have changed or may have failed SATA Init previously.");
                                    Console.WriteLine("             Device will be reset.");    
                                }
                                Console.WriteLine(" "); 
                                break;
                            case "F":
                                Console.WriteLine("0x00000F00: PL_LOGINFO_SUB_CODE_SECOND_OPEN");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Not used.");
                                break;
                        }
                        switch(PLErrorcode7)
                        {
                            case "12":
                                Console.WriteLine("0x00000120: PL_LOGINFO_SUB_CODE_TARGET_BUS_RESET");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Target mode aborting I/O after receiving hard reset.");
                                Console.WriteLine("             This can also be due to open fail no destination or open reject retry");
                                Console.WriteLine("             and retry count has been exceeded(1.25 seconds).");
                                Console.WriteLine(" "); 
                                break;

                            case "13":
                                if (PLErrorcode8 == "131")
                                {
                                    Console.WriteLine("0x00000131: PL_LOGINFO_SUB_CODE_TRANSPORT_LAYER_1");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode aborts the I/O due to");
                                    Console.WriteLine("             frame transfer error or wrong relative offset detected.");
                                }
                                else if (PLErrorcode8 == "132")
                                {
                                    Console.WriteLine("0x00000132: PL_LOGINFO_SUB_CODE_TRANSPORT_LAYER_2");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode aborts the I/O due to");
                                    Console.WriteLine("             bad DMA detected in send operation(for example: Invalid SGL).");
                                }
                                else if (PLErrorcode8 == "133")
                                {
                                    Console.WriteLine("0x00000133: PL_LOGINFO_SUB_CODE_TRANSPORT_LAYER_3");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode aborts the I/O after receiving frame with wrong frame length,");
                                    Console.WriteLine("             wrong relative offset, or zero write data length in XFER_RDY.");
                                }
                                else if (PLErrorcode8 == "134")
                                {
                                    Console.WriteLine("0x00000134: PL_LOGINFO_SUB_CODE_TRANSPORT_LAYER_4");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode detected open connection and received BREAK.");
                                    Console.WriteLine("             Aborting the I/O.");
                                }
                                else if (PLErrorcode8 == "135")
                                {
                                    Console.WriteLine("0x00000135: PL_LOGINFO_SUB_CODE_TRANSPORT_LAYER_5");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode abor ted the I/O due to either of the following:");
                                    Console.WriteLine("             • Received XFER_RDY or response frame before the data transfer has completed.");
                                    Console.WriteLine("             • Retry count has been exceeded.");
                                }
                                else
                                {
                                    Console.WriteLine("0x00000130: PL_LOGINFO_SUB_CODE_TRANSPORT_LAYER");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode aborts the I/O due to ");
                                    Console.WriteLine("             bad DMA detected in receive operation(for example: Invalid SGL).");
                                }
                                break;
                            case "14":
                                if(PLErrorcode8 == "141")
                                {
                                    Console.WriteLine("0x00000141: PL_LOGINFO_SUB_CODE_PORT_LAYER_1");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Error detected in target mode data transfer I/O.");
                                    Console.WriteLine("             Aborting the I / O.");
                                }else if(PLErrorcode8 == "142")
                                {
                                    Console.WriteLine("0x00000142: PL_LOGINFO_SUB_CODE_PORT_LAYER_2");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Error detected in transfer ready or response frame.");
                                    Console.WriteLine("             Aborting the I / O.");
                                }
                                else if(PLErrorcode8 == "143")
                                {
                                    Console.WriteLine("0x00000143: PL_LOGINFO_SUB_CODE_PORT_LAYER_3");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Target mode open failure due to no destination,");
                                    Console.WriteLine("             rate not supported, or break received.Aborting the I / O.");
                                }
                                else
                                {
                                    Console.WriteLine("0x00000140: PL_LOGINFO_SUB_CODE_PORT_LAYER");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Error detected in target mode I/O (non-data transfer).");
                                    Console.WriteLine("             Aborting the I / O.");
                                }
                                Console.WriteLine(" "); 
                                break;
                        }
                        switch (PLErrorcode8)
                        {
                            case "101":
                                Console.WriteLine("0x00000101: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_NO_DEST_TIMEOUT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection with error Open Reject (No Destination).");
                                Console.WriteLine("             Retried for 50milliseconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "102":
                                Console.WriteLine("0x00000102: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_SATA_NEG_RATE_2HI");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection due to negotiated rate on link is higher than the SATA device.");
                                Console.WriteLine("             Retried for 50 milliseconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "103":
                                Console.WriteLine("0x00000103: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_RATE_NOT_SUPPORTED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection due to rate not supported.");
                                Console.WriteLine("             Retried for 50milliseconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "104":
                                Console.WriteLine("0x00000104: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_BREAK");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection due to break received.");
                                Console.WriteLine("             Retried for 50milliseconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "114":
                                Console.WriteLine("0x00000114: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_ABANDON0");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection due to Zone violation,");
                                Console.WriteLine("             used in SAS2 firmware.");
                                Console.WriteLine(" "); 
                                Console.WriteLine("0x00000114: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_ZONE_VIOLATION");
                                Console.WriteLine(" ");
                                Console.WriteLine("Explanation: Failed to open connection used in SAS1 firmware.");
                                Console.WriteLine(" ");
                                break;
                            case "115":
                                Console.WriteLine("0x00000115: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_ABANDON1");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection.");
                                Console.WriteLine("             yet to assign a specific name and currently it is reserved.");
                                Console.WriteLine(" "); 
                                break;
                            case "116":
                                Console.WriteLine("0x00000116: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_ABANDON2");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection.");
                                Console.WriteLine("             yet to assign a specific name and currently it is reserved.");
                                Console.WriteLine(" "); 
                                break;
                            case "117":
                                Console.WriteLine("0x00000117: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_ABANDON3");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection.");
                                Console.WriteLine("             yet to assign a specific name and currently it is reserved.");
                                Console.WriteLine(" "); 
                                break;
                            case "11A":
                                Console.WriteLine("0x0000011A: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_ORR_TIMEOUT");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection with error.");
                                Console.WriteLine("             Open Reject Retry, and retry count exceeded.Retried for 1.25 seconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "11B":
                                Console.WriteLine("0x0000011B: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_PATH_BLOCKED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection, retry count for pathway blocked exceeded.");
                                Console.WriteLine("             Retried for 50milliseconds.");
                                Console.WriteLine(" "); 
                                break;
                            case "11C":
                                Console.WriteLine("0x0000011C: PL_LOGINFO_SUB_CODE_OPEN_FAILURE_AWT_MAXED");
                                Console.WriteLine(" "); 
                                Console.WriteLine("Explanation: Failed to open connection, arbitration wait timer exceeded.");
                                Console.WriteLine("             Retried for 50 milliseconds.");
                                Console.WriteLine(" "); 
                                break;                             
                        }
                        switch (PLErrorcode9)
                        {
                            case "01":
                                if(PLErrorcode1 == "F0001" || PLErrorcode8 == "101" || 
                                    PLErrorcode2 == "200101" || PLErrorcode7 == "E01")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000001: PL_LOGINFO_SUB_CODE_OPEN_FAIL_NO_DEST_TIME_OUT");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: No destination timeout");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "02":
                                if(PLErrorcode8 == "102" || PLErrorcode2 == "200102")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000002: PL_LOGINFO_SUB_CODE_OPEN_FAIL_PATHWAY_BLOCKED");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Pathway blocked");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "03":
                                if(PLErrorcode8 == "103" || PLErrorcode2 == "200103")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000003: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RES_CONTINUE0");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Reserved Continue 0");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "04":
                                if(PLErrorcode8 == "104" || PLErrorcode2 == "200104")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000004: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RES_CONTINUE1");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Continue 1");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "05":
                                if(PLErrorcode2 == "200105")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000005: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RES_INITIALIZE0");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Initialize 0");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "06":
                                if(PLErrorcode2 == "200106")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000006: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RES_INITIALIZE1");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Initialize 1");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "07":
                                if(PLErrorcode2 == "200107")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000007: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RES_STOP0");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Stop 0");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "08":
                                if(PLErrorcode2 == "200108")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000008: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RES_STOP1");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Stop 1");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "09":
                                if(PLErrorcode2 == "200109")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000009: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RETRY");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Retry");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "0A":
                                if(PLErrorcode2 == "20010A")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x0000000A: PL_LOGINFO_SUB_CODE_OPEN_FAIL_BREAK");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Break");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "0B":
                                if(PLErrorcode2 == "20010B")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x0000000B: PL_LOGINFO_SUB_CODE_OPEN_FAIL_UNUSED_0B");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Unused");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "0C":
                                if(PLErrorcode2 == "20010C")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x0000000C: PL_LOGINFO_SUB_CODE_OPEN_FAIL_OPEN_TIMEOUT_EXP");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Timeout expired");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "0D":
                                if(PLErrorcode2 == "20010D")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x0000000D: PL_LOGINFO_SUB_CODE_OPEN_FAIL_UNUSED_0D");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Unused");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "0E":
                                if(PLErrorcode2 == "20010E")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x0000000E: PL_LOGINFO_SUB_CODE_OPEN_FAIL_DVTBLE_ACCSS_FAIL");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Device Table access failed");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "0F":
                                if(PLErrorcode2 == "20010F")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x0000000F: It didn' t recored on /drivers/message/fusion/lsi/mpi_log_sas.h");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Unused");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10":
                                if(PLErrorcode2 == "200110")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0x00000110: It didn' t recored on /drivers/message/fusion/lsi/mpi_log_sas.h");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Unused");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "11":
                                if(PLErrorcode2 == "200111")
                                {
                                    break;
                                }
                                else 
                                {
                                    Console.WriteLine("0x00000011: PL_LOGINFO_SUB_CODE_OPEN_FAIL_BAD_DEST");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Bad destination");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "12":
                                {
                                    Console.WriteLine("0x00000012: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RATE_NOT_SUPP");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Rate not supported");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "13":
                                {
                                    Console.WriteLine("0x00000013: PL_LOGINFO_SUB_CODE_OPEN_FAIL_PROT_NOT_SUPP");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Protocol not supported");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "14":
                                {
                                    Console.WriteLine("0x00000014: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RESERVED_ABANDON0");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Abandon 0");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "15":
                                {
                                    Console.WriteLine("0x00000015: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RESERVED_ABANDON1");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Abandon 1");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "16":
                                {
                                    Console.WriteLine("0x00000016: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RESERVED_ABANDON2");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Reserved Abandon 2");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "17":
                                {
                                    Console.WriteLine("0x00000017: PL_LOGINFO_SUB_CODE_OPEN_FAIL_RESERVED_ABANDON3");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Reserved Abandon 3");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "18":
                                {
                                    Console.WriteLine("0x00000018: PL_LOGINFO_SUB_CODE_OPEN_FAIL_STP_RESOURCES_BSY");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: STP Resource busy");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "19":
                                {
                                    Console.WriteLine("0x00000019: PL_LOGINFO_SUB_CODE_OPEN_FAIL_WRONG_DESTINATION");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Wrong destination");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "1B":
                                {
                                    Console.WriteLine("0x0000001B: PL_LOGINFO_SUB_CODE_OPEN_FAIL_PATH_BLOCKED");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Pathway blocked, retry timeout");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                            case "1C":
                                {
                                    Console.WriteLine("0x0000001C: PL_LOGINFO_SUB_CODE_OPEN_FAIL_AWT_MAXED");
                                    Console.WriteLine(" "); 
                                    Console.WriteLine("Explanation: Arbitration Wait Timer maxed");
                                    Console.WriteLine(" "); 
                                    break;
                                }
                           }
                    }else if(WheredidOriginatorcomefrom == "2")
                    {
                        string IRErrorcode = code.Substring(5, 5).ToUpper();
                        switch(IRErrorcode)
                        {
                            case "10000":
                                {
                                    Console.WriteLine("0x00010000: IR_LOGINFO_RAID_ACTION_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: There is no explanation on manual");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "20000":
                                {
                                    Console.WriteLine("0x00020000: IR_LOGINFO_CODE_UNUSED2");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: There is no explanation on manual");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10001":
                                {
                                    Console.WriteLine("0x00010001: IR_LOGINFO_VOLUME_CREATE_INVALID_LENGTH");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Amount of information passed down for Create Volume is too large.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10002":
                                {
                                    Console.WriteLine("0x00010002: IR_LOGINFO_VOLUME_CREATE_DUPLICATE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation of duplicate volume attempted (Bus/Target ID checked).");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10003":
                                {
                                    Console.WriteLine("0x00010003: IR_LOGINFO_VOLUME_CREATE_NO_SLOTS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to maximum number of supported volumes exceeded.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10004":
                                {
                                    Console.WriteLine("0x00010004: IR_LOGINFO_VOLUME_CREATE_DMA_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to DMA error in trying to read from host.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10005":
                                {
                                    Console.WriteLine("0x00010005: IR_LOGINFO_VOLUME_CREATE_INVALID_VOLUME_TYPE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to invalid volume type passed down.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10006":
                                {
                                    Console.WriteLine("0x00010006: IR_LOGINFO_VOLUME_MFG_PAGE4_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to error reading MFG Page 4.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10007":
                                {
                                    Console.WriteLine("0x00010007: IR_LOGINFO_VOLUME_INTERNAL_CONFIG_STRUCTURE_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed when trying to create internal structures.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10010":
                                {
                                    Console.WriteLine("0x00010010: IR_LOGINFO_VOLUME_ACTIVATING_AN_ACTIVE_VOLUME");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed due to trying to activate an already active volume.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10011":
                                {
                                    Console.WriteLine("0x00010011: IR_LOGINFO_VOLUME_ACTIVATING_INVALID_VOLUME_TYPE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed due to trying to active unsupported volume type.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10012":
                                {
                                    Console.WriteLine("0x00010012: IR_LOGINFO_VOLUME_ACTIVATING_TOO_MANY_VOLUMES");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed due to trying to active too many volumes.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10013":
                                {
                                    Console.WriteLine("0x00010013: IR_LOGINFO_VOLUME_ACTIVATING_VOLUME_ID_IN_USE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed due to Volume ID in use already.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10014":
                                {
                                    Console.WriteLine("0x00010014: IR_LOGINFO_VOLUME_ACTIVATE_VOLUME_FAILED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed call to activate Volume returned failure.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10015":
                                {
                                    Console.WriteLine("0x00010015: IR_LOGINFO_VOLUME_ACTIVATING_IMPORT_VOLUME_FAILED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed trying to import the volume.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10016":
                                {
                                    Console.WriteLine("0x00010016: IR_LOGINFO_VOLUME_ACTIVATING_TOO_MANY_PHYS_DISKS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Activation failed, too many phys disks.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10020":
                                {
                                    Console.WriteLine("0x00010020: IR_LOGINFO_PHYSDISK_CREATE_TOO_MANY_DISKS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Phys Disk failed, too many phys disks");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10021":
                                {
                                    Console.WriteLine("0x00010021: IR_LOGINFO_PHYSDISK_CREATE_INVALID_LENGTH");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Amount of information passed down for Create Phys Disk is too large.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10022":
                                {
                                    Console.WriteLine("0x00010022: IR_LOGINFO_PHYSDISK_CREATE_DMA_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to DMA error in trying to read from host.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10023":
                                {
                                    Console.WriteLine("0x00010023: IR_LOGINFO_PHYSDISK_CREATE_BUS_TID_INVALID");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to invalid Bus TargetID passed down.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10024":
                                {
                                    Console.WriteLine("0x00010024: IR_LOGINFO_PHYSDISK_CREATE_CONFIG_PAGE_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to error in creating RAID Phys Disk Config Page.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10025":
                                {
                                    Console.WriteLine("0x00010025: IR_LOGINFO_PHYSDISK_CREATE_DUAL_PORT_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Creation failed due to error in creating dual port.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10026":
                                {
                                    Console.WriteLine("0x00010026: IR_LOGINFO_PHYSDISK_DUAL_PORT_FAILOVER");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Both paths are unavailable for the Dual Pathing device.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10030":
                                {

                                    Console.WriteLine("0x00010030: IR_LOGINFO_COMPAT_ERROR_RAID_DISABLED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: IR Disabled.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10031":
                                {
                                    Console.WriteLine("0x00010031: IR_LOGINFO_COMPAT_ERROR_INQUIRY_FAILED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Inquiry command failed.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10032":
                                {
                                    Console.WriteLine("0x00010032: IR_LOGINFO_COMPAT_ERROR_NOT_DIRECT_ACCESS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error : Device not direct access device.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10033":
                                {
                                    Console.WriteLine("0x00010033: IR_LOGINFO_COMPAT_ERROR_REMOVABLE_FOUND");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Removable device found.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10034":
                                {
                                    Console.WriteLine("0x00010034: IR_LOGINFO_COMPAT_ERROR_NEED_SCSI_2_OR_HIGHER");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Device SCSI version not 2 or higher.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10035":
                                {
                                    Console.WriteLine("0x00010035: IR_LOGINFO_COMPAT_ERROR_SATA_48BIT_LBA_NOT_SUPPORTED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: SATA device, 48-bit LBA not supported.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10036":
                                {
                                    Console.WriteLine("0x00010036: IR_LOGINFO_COMPAT_ERROR_DEVICE_NOT_512_BYTE_BLOCK");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Device does not have 512 byte block sizes.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10037":
                                {
                                    Console.WriteLine("0x00010037: IR_LOGINFO_COMPAT_ERROR_VOLUME_TYPE_CHECK_FAILED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Volume Type check failed.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10038":
                                {
                                    Console.WriteLine("0x00010038: IR_LOGINFO_COMPAT_ERROR_UNSUPPORTED_VOLUME_TYPE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Volume Type is unsupported by FW.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10039":
                                {
                                    Console.WriteLine("0x00010039: IR_LOGINFO_COMPAT_ERROR_DISK_TOO_SMALL");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Disk drive too small for use in volume.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "1003A":
                                {
                                    Console.WriteLine("0x0001003A: IR_LOGINFO_COMPAT_ERROR_PHYS_DISK_NOT_FOUND");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: Phys disk for Create Volume not found.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "1003B":
                                {
                                    Console.WriteLine("0x0001003B: IR_LOGINFO_COMPAT_ERROR_MEMBERSHIP_COUNT");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error : membership count error, too many or too few disks for volume type.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "1003C":
                                {
                                    Console.WriteLine("0x0001003C: IR_LOGINFO_COMPAT_ERROR_NON_64K_STRIPE_SIZE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error : Disk stripe sizes must be 64-KB.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "1003D":
                                {
                                    Console.WriteLine("0x0001003D: IR_LOGINFO_COMPAT_ERROR_IME_VOL_NOT_CURRENTLY_SUPPORTED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Compatibility Error: IME size limited to < 2TB.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "1003E":
                                {
                                    Console.WriteLine("0x0001003E: IR_LOGINFO_COMPAT_ERROR_MEDIA_TYPE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: The media type of the device is undefined.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10050":
                                {
                                    Console.WriteLine("0x00010050: IR_LOGINFO_DEV_FW_UPDATE_ERR_DFU_IN_PROGRESS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: DFU can only be started once.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10051":
                                {
                                    Console.WriteLine("0x00010051: IR_LOGINFO_DEV_FW_UPDATE_ERR_DEVICE_IN_INVALID_STATE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: Volume must be Optimal / Active / non - quiesced.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10052":
                                {
                                    Console.WriteLine("0x00010052: IR_LOGINFO_DEV_FW_UPDATE_ERR_INVALID_TIMEOUT");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: DFU Timeout cannot be zero.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10053":
                                {
                                    Console.WriteLine("0x00010053: IR_LOGINFO_DEV_FW_UPDATE_ERR_NO_TIMERS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: CREATE TIMER FAILED.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10054":
                                {
                                    Console.WriteLine("0x00010054: IR_LOGINFO_DEV_FW_UPDATE_ERR_READING_CFG_PAGE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: Failed to read SAS_IO_UNIT_PG_1.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10055":
                                {
                                    Console.WriteLine("0x00010055: IR_LOGINFO_DEV_FW_UPDATE_ERR_PORT_IO_TIMEOUTS_REQUIRED");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: Invalid SAS_IO_UNIT_PG_1 value(s).");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "10056":
                                {
                                    Console.WriteLine("0x00010056: IR_LOGINFO_DEV_FW_UPDATE_ERR_ALLOC_CFG_PAGE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: Device Firmware Update: Unable to allocate memory for page.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            case "40000":
                                {
                                    Console.WriteLine("0x00040000: MPI_IOCSTATUS_INTERNAL_ERROR");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Explanation: I/O a borted due to work a round.");
                                    Console.WriteLine(" ");
                                    break;
                                }
                        }
                    }else if (WheredidOriginatorcomefrom == "F")
                    {
                        string MaskErrorcode = code.Substring(4, 2).ToUpper();
                        switch (MaskErrorcode)
                        {
                            case "FF":
                                {
                                    
                                    if(makesureType == "F" && WheredidOriginatorcomefrom == "F")
                                    {
                                        Console.WriteLine("0x00FF0000: IOC_LOGINFO_CODE_MASK");
                                        Console.WriteLine("0xFFFF0000: SAS_LOGINFO_MASK");
                                    }
                                    else
                                    {
                                        Console.WriteLine("0x00FF0000: IOC_LOGINFO_CODE_MASK");
                                    }
                                    
                                    break;
                                }
                        }
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine(" ");
                }
            }

        }
    }
}
